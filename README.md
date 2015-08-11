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

#### Simple Query

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
        Surname = st.SURNAME,
        HomeGroup = st.HOME_GROUP,
        YearLevel = st.SCHOOL_YEAR
    });
```

#### Navigation Properties

Data set relationships can be navigated with additional data sets automatically loaded when needed

```C#
// Create Context
var Context = new EduHubContext();

// Build using query syntax
// ST.FAMILY_DF and DF.HOMEKEY_UM navigation properties used
var activeStudentTowns = (
    from st in Context.ST
    where st.STATUS == "ACTV"
    orderby st.SCHOOL_YEAR, st.HOME_GROUP
    select new
    {
        StudentCode = st.STKEY,
        HomeGroup = st.HOME_GROUP,
        YearLevel = st.SCHOOL_YEAR,
        Town = st.FAMILY_DF.HOMEKEY_UM.ADDRESS03,
        PostCode = st.FAMILY_DF.HOMEKEY_UM.POSTCODE
    });
```