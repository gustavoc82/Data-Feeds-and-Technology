<div align="center">
    <img src="./assets/logo.png" width="290">
    <p><b>MScFE 670 Data Feeds and Technology<br>
    Group Work Assignment</b><br>
    April 13, 2020</p>
    <i>
    Aaron Jones - <a href="mailto:aspcul8r@gmail.com">aspcul8r@gmail.com</a><br>
    Gustavo Campos - <a href="mailto:gustavoc82@me.com">gustavoc82@me.com</a><br>
    Mahsa Kiani - <a href="mailto:mahsa.kiani@ieee.org">mahsa.kiani@ieee.org</a><br>
    Jared Marks - <a href="mailto:jared.marks@live.com">jared.marks@live.com</a>
    </i>
    <p></p>
    <p><b>Abstract</b></p>
</div>
In this article... <b>Mahsa Task</b><br>
<b><i>Keywords:</i></b> Keywords...
<p></p>

---

# Introduction

**Mahsa Task**

# Using C# and Excel to Track Property Prices

For this submission, you will explore the use of C# and Excel to keep track of the pricing of various properties. You are required to implement various useful statistical calculations which will allow you to gain further insight into the overall trends of the property market.

You are provided with skeleton code which includes an already implemented command line interface, which functions according to the menu presented when the application is run:

```
Select an option (1,2,3,4,5) or enter 'x' to quit...
1: Add Property
2: Calculate Mean
3: Calculate Variance
4: Calcualte Minimum
5: Calcualte Maximum
```

For this submission, complete the following tasks:

1. **Set up the worksheet when the application is launched for the first time**. The main method already calls a method `SetUp`; therefore, you simply have to implement this method, which should create a new Excel workbook titled `property_pricing.xlsx`

#### Answer

When the application is launched, the Main method attempts to open an existing workbook: 
```csharp
try
{
    workbook = app.Workbooks.Open("property_pricing.xlsx", ReadOnly: false);
}
```
If the workbook has not been saved before in the file path, method `SetUp` is called:
```csharp
    catch
    {
        Setup();
    }
```
`Setup` Method   
```csharp
static void SetUp()
{
    // add a workbook and set it as active
    app.Workbooks.Add();
    workbook = app.ActiveWorkbook;

    // set current worksheet
    Excel._Worksheet currentSheet = workbook.Worksheets[1];

    // set sheet name
    currentSheet.Name = "Properties";

    // set columns names
    currentSheet.Cells[1, "A"] = "Size (sf)";
    currentSheet.Cells[1, "B"] = "Suburb";
    currentSheet.Cells[1, "C"] = "City";
    currentSheet.Cells[1, "D"] = "Value";
    currentSheet.Cells[1, "E"] = 0;

    // save workbook
    workbook.SaveAs("property_pricing.xlsx");
}
```
As the Main method has visbility set to true ```app.Visible=true;```, an excel workbook opens and populates the active worksheet with specified header names: Size (sf), Subrub, City, Value, and 0. The sheet name is changed from default Sheet1 to Properties and then is saved as property_pricing.xlsx. In this instance, '0' is being used to initiate a row counter for future use.

![setupmethod_results](setupmethod_results.png)

2. **Implement the adding of property information to the sheet**. The property information headers are as follows:

- Size (in square feet)
- Suburb
- City
- Market value

The command line interface already calls a method `AddPropertyToWorksheet`, so you will simply have to implement this method.

*Note:* It will be useful here to make use of a counter, which can be stored to the right of the last header, so that you have an easy reference to know how many rows of data are stored in the sheet. This will be useful for the statistical calculations, and to know where each row should be inserted when adding new rows. The counter would be a number stored in a known cell.

#### Answer

After the Main method has opened an existing workbook or has run through the `SetUp` method described above, it opens a console screen and awaits user input:

![console_menu](console_menu.png)

When the console user enters number 1 (Add Property), Main method prompts to fill variables size, suburb, city, and value. When enter has been pressed for all prompts, Main method calls `AddPropertyToWorksheet` and passes the user filled variables.

![property_entry](property_entry.png)

`AddPropertyToWorksheet` Method
```csharp
static void AddPropertyToWorksheet(float size, string suburb, string city, float value)
{
    // set current worksheet
    Excel.Worksheet currentSheet = workbook.Worksheets[1];
            
    var nrows = currentSheet.Cells[1, "E"].value;
    nrows += 2; // need to increment since nrows above is the last FILLED row
            
    // add property data to the table 
    currentSheet.Cells[nrows, "A"] = size;
    currentSheet.Cells[nrows, "B"] = suburb;
    currentSheet.Cells[nrows, "C"] = city;
    currentSheet.Cells[nrows, "D"] = value;
    currentSheet.Cells[1, "E"] = nrows - 1;
}
```
The nrow counter variable refers to the value present in row 1, cell E. Following the initial user experience desribed in the `SetUp` method, the nrow value is initiated as 0. For each loop of user console input in with value '1' (Add Property), the nrow value advances to a new row and populates cells based on new user input.

![excel_entry](excel_entry.png)

3. **Implement statistical methods**. In the skeleton code you find the following four statistical methods already declared:

- Mean market value
- Variance in market value
- Minimum market value
- Maximum market value

Your task is to update these methods to perform the correct work based on the data from the sheet. These methods are already called in the command line interface, so you only need to implement the method.

##### Answer


**Implementation write-up: Gustavo**


### Mean market Value

```csharp
static float CalculateMean()
{
    // set current worksheet
    Excel.Worksheet currentSheet = workbook.Worksheets[1];

    // number of properties
    var nrows = currentSheet.Cells[1, "E"].value;

    if(nrows > 0)
    {
        //This is how we get range from Excel worksheet
        var range = currentSheet.Range["D2:D" + (nrows + 1).ToString()];

        // create a list with the range values
        List<float> prices = new List<float>();
        foreach (var cell in range)
        {
            prices.Add((int)cell.Value);
        }

        // return mean
        return prices.Average();
    }

    return 0.0f;
}
```

### Variance in market value

```csharp
static float CalculateVariance()
{
    // set current worksheet
    Excel.Worksheet currentSheet = workbook.Worksheets[1];

    // number of properties
    var nrows = currentSheet.Cells[1, "E"].value;

    if (nrows > 0)
    {
        //This is how we get range from Excel worksheet
        var range = currentSheet.Range["D2:D" + (nrows + 1).ToString()];

        // create a list with the range values
        List<float> prices = new List<float>();
        foreach (var cell in range)
        {
            prices.Add((int)cell.Value);
        }

        // return Variance
        return (float)(prices.Average(z => z * z) - Math.Pow(prices.Average(), 2));
    }

    return 0.0f;
}
```

### Minimum market value

```csharp
static float CalculateMinimum()
{
    // set current worksheet
    Excel.Worksheet currentSheet = workbook.Worksheets[1];

    // number of properties
    var nrows = currentSheet.Cells[1, "E"].value;

    if (nrows > 0)
    {
        //This is how we get range from Excel worksheet
        var range = currentSheet.Range["D2:D" + (nrows + 1).ToString()];

        // create a list with the range values
        List<float> prices = new List<float>();
        foreach (var cell in range)
        {
            prices.Add((int)cell.Value);
        }

        // return min
        return prices.Min();
    }

    return 0.0f;
}
```

### Maximum market value

```csharp
static float CalculateMaximum()
{
    // set current worksheet
    Excel.Worksheet currentSheet = workbook.Worksheets[1];

    // number of properties
    var nrows = currentSheet.Cells[1, "E"].value;

    if (nrows > 0)
    {
        //This is how we get range from Excel worksheet
        var range = currentSheet.Range["D2:D" + (nrows + 1).ToString()];

        // create a list with the range values
        List<float> prices = new List<float>();
        foreach (var cell in range)
        {
            prices.Add((int)cell.Value);
        }

        // return max
        return prices.Max();
    }

    return 0.0f;
}
```

**Functionality write-up: Gustavo**

# Conclusion

**Mahsa Task**

# References
