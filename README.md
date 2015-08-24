eduHub Data
====================


A .NET (C#, Visual Basic.NET, etc) strongly-typed object model which provides in-memory, lazy-loading of eduHub CSV Data Sets.

> #### [on NuGet](https://nuget.org/packages/EduHub.Data/)
> ```PowerShell
> Install-Package EduHub.Data
> ```

----------


USAGE
-----

#### Simple Query (C#)

All active students

```C#
// Create context
var Context = new EduHubContext();

// Build using query syntax
var activeStudents = (
    from st in Context.ST
    where st.STATUS == "ACTV"
    select new
    {
        StudentCode = st.STKEY,
        Name = $"{st.SURNAME}, {st.FIRST_NAME}",
        HomeGroup = st.HOME_GROUP,
        YearLevel = st.SCHOOL_YEAR
    });
```

#### Navigation Properties (C#)

Data set relationships can be navigated with additional data sets automatically loaded when needed

```C#
// Create Context
var Context = new EduHubContext();

// Build using query syntax
// ST.FAMILY_DF and DF.HOMEKEY_UM navigation properties used
var activeStudentTowns = (
    from st in Context.ST
    let family = st.FAMILY_DF
    let home = family.HOMEKEY_UM
    where st.STATUS == "ACTV"
    orderby st.SCHOOL_YEAR, st.HOME_GROUP
    select new
    {
        StudentCode = st.STKEY,
        HomeGroup = st.HOME_GROUP,
        YearLevel = st.SCHOOL_YEAR,
        Town = home.ADDRESS03,
        PostCode = home.POSTCODE
    });
```

#### PowerShell Example

[Download the latest release for PowerShell](https://github.com/garysharp/EduHub.Data/releases)

```PowerShell
Add-Type -Path "EduHub.Data.dll";

$eduHubContext = New-Object EduHub.Data.EduHubContext;

$studentAddresses = $eduHubContext.ST `
    | Where-Object { $_.STATUS -eq "ACTV" } `
    | Select-Object -Property `
        STKEY,
        SURNAME,
        FIRST_NAME,
        HOME_GROUP,
        SCHOOL_YEAR,
        @{ Name = "BILLINGTITLE"; Expression = { $_.FAMILY_DF.BILLINGTITLE } },
        @{ Name = "ADDRESS01";    Expression = { $_.FAMILY_DF.BILLINGKEY_UM.ADDRESS01 } },
        @{ Name = "ADDRESS02";    Expression = { $_.FAMILY_DF.BILLINGKEY_UM.ADDRESS02 } },
        @{ Name = "ADDRESS03";    Expression = { $_.FAMILY_DF.BILLINGKEY_UM.ADDRESS03 } },
        @{ Name = "STATE";        Expression = { $_.FAMILY_DF.BILLINGKEY_UM.STATE } },
        @{ Name = "COUNTRY";      Expression = { $_.FAMILY_DF.BILLINGKEY_UM.COUNTRY_KGT.DESCRIPTION } };

$studentAddresses | Export-Csv StudentAddresses.csv -NoTypeInformation
```