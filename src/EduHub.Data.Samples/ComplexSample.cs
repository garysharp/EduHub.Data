using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace EduHub.Data.Samples
{
    public static class ComplexSample
    {
        private struct GeneralLedgerBudgetItem
        {
            public string Key;
            public string BudgetID;
            public string GeneralLedgerTypeID;
            public string BudgetType;
            public decimal AnnualBudgetAmount;
            public decimal YearToDateAmount;
            public decimal CommittedAmount;
        }

        public static void Run()
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Complex Sample");
            ForegroundColor = ConsoleColor.White;
            WriteLine("Determines program general ledger budgets.");
            WriteLine();

            // Create an EduHubContext
            var Context = new EduHubContext();

            // Build Query
            int TransactionPeriod = DateTime.Now.Year * 100;

            // Determine year-to-date amounts
            var yearToDateAmounts = Context.GLF
                .Where(e => e.SUBPROGRAM != "0000" &&
                        (e.CODE_GL.GL_TYPE == "I" || e.CODE_GL.GL_TYPE == "E" || (e.CODE.CompareTo("26000") > 0 && e.CODE.CompareTo("29999") < 0)))
                .Where(e => e.TRPERD >= TransactionPeriod && e.TRAMT != 0)
                .GroupBy(e => new
                {
                    GL = e.CODE_GL,
                    KGLSUB = e.SUBPROGRAM_KGLSUB
                })
                .Select(e => new GeneralLedgerBudgetItem()
                {
                    Key = $"{e.Key.GL.CODE}_{e.Key.KGLSUB.SUBPROGRAM}",
                    BudgetID = e.Key.KGLSUB.SUBPROGRAM,
                    GeneralLedgerTypeID = e.Key.GL.CODE,
                    BudgetType = e.Key.GL.GL_TYPE,
                    YearToDateAmount = e.Sum(i => i.TRAMT).Value,
                }).ToDictionary(k => k.Key);

            // Determine annual budget amounts
            var annualBudgetAmounts = Context.GLBUDG
                .Where(e => e.SUBPROGRAM != "0000" &&
                        (e.CODE_GL.GL_TYPE == "I" || e.CODE_GL.GL_TYPE == "E" || (e.CODE.CompareTo("26000") > 0 && e.CODE.CompareTo("29999") < 0)) &&
                        e.ANNUALBUDG != 0)
                .GroupBy(e => new
                {
                    GL = e.CODE_GL,
                    KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(e.SUBPROGRAM)
                })
                .Select(e => new GeneralLedgerBudgetItem()
                {
                    Key = $"{e.Key.GL.CODE}_{e.Key.KGLSUB.SUBPROGRAM}",
                    BudgetID = e.Key.KGLSUB.SUBPROGRAM,
                    GeneralLedgerTypeID = e.Key.GL.CODE,
                    BudgetType = e.Key.GL.GL_TYPE,
                    AnnualBudgetAmount = e.Sum(i => i.ANNUALBUDG).Value
                }).ToDictionary(k => k.Key);

            var glInventoryOnHand = Context.GL.FindByCODE("11003");

            // Determine committed amounts
            var committedAmounts = Context.CRF
                .Where(e => e.SUBPROGRAM != "0000")
                .Where(e => e.TRTYPE == "O" &&
                        e.TRQTYI + e.TRQTYIX < e.TRQTY &&
                        e.TRCOST != 0 &&
                        (e.ATKEY_AR != null || e.TRXLEDGER == "IV" || Context.GL.TryFindByCODE(e.TRXCODE) != null))
                .Select(e => new
                {
                    GL = e.ATKEY_AR != null
                        ? e.ATKEY_AR.CATEGORY_AKC.GLCODE_ASS_GL
                        : e.TRXLEDGER == "IV"
                            ? glInventoryOnHand
                            : e.Context.GL.TryFindByCODE(e.TRXCODE),
                    KGLSUB = e.SUBPROGRAM_KGLSUB,
                    Commitment = (e.TRQTY - e.TRQTYI - e.TRQTYIX) * e.TRCOST
                })
                .Where(e =>
                    e.GL.GL_TYPE == "I" || e.GL.GL_TYPE == "E" ||
                    (e.GL.CODE.CompareTo("26000") > 0 && e.GL.CODE.CompareTo("29999") < 0))
                .GroupBy(e => new
                {
                    e.GL,
                    e.KGLSUB
                })
                .Select(e => new GeneralLedgerBudgetItem()
                {
                    Key = $"{e.Key.GL.CODE}_{e.Key.KGLSUB.SUBPROGRAM}",
                    BudgetID = e.Key.KGLSUB.SUBPROGRAM,
                    GeneralLedgerTypeID = e.Key.GL.CODE,
                    BudgetType = e.Key.GL.GL_TYPE,
                    CommittedAmount = e.Sum(i => i.Commitment).Value
                }).ToDictionary(k => k.Key);

            var keys = yearToDateAmounts.Keys.Concat(annualBudgetAmounts.Keys).Concat(committedAmounts.Keys).Distinct().ToList();

            // Join all data
            var budgets = keys
                .Select(key =>
                {
                    GeneralLedgerBudgetItem validItem = default(GeneralLedgerBudgetItem);
                    GeneralLedgerBudgetItem testItem;
                    decimal annualBudgetAmount = default(decimal);
                    decimal yearToDateAmount = default(decimal);
                    decimal committedAmount = default(decimal);

                    if (annualBudgetAmounts.TryGetValue(key, out testItem))
                    {
                        validItem = testItem;
                        annualBudgetAmount = testItem.AnnualBudgetAmount;
                    }
                    if (yearToDateAmounts.TryGetValue(key, out testItem))
                    {
                        validItem = testItem;
                        yearToDateAmount = testItem.YearToDateAmount;
                    }
                    if (committedAmounts.TryGetValue(key, out testItem))
                    {
                        validItem = testItem;
                        committedAmount = testItem.CommittedAmount;
                    }

                    return new GeneralLedgerBudgetItem()
                    {
                        BudgetID = validItem.BudgetID,
                        GeneralLedgerTypeID = validItem.GeneralLedgerTypeID,
                        BudgetType = validItem.BudgetType,
                        AnnualBudgetAmount = annualBudgetAmount,
                        YearToDateAmount = yearToDateAmount,
                        CommittedAmount = committedAmount
                    };
                })
                .OrderBy(i => i.BudgetID).ThenBy(i => i.BudgetType).ThenBy(i => i.GeneralLedgerTypeID)
                .ToList();

            // Write Headers to Console
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"BudgetID",-9} {"Type",-4} {"GL",-10} {"Budget",15} {"Spent",15} {"Committed",15}");

            // Write Data to Console
            ForegroundColor = ConsoleColor.Gray;
            foreach (var budget in budgets)
            {
                WriteLine($"{budget.BudgetID,-9} {budget.BudgetType,-4} {budget.GeneralLedgerTypeID,-10} {budget.AnnualBudgetAmount,15:C2} {budget.YearToDateAmount,15:C2} {budget.CommittedAmount,15:C2}");
            }
        }
    }
}
