<div align="center">
    <img src="./assets/logo.png" width="290">
    <p><b>MScFE 670 Data Feeds and Technology<br>
    Group Work Assignment</b><br>
    April 13, 2020</p>
    <i>
    Aaron Jones - <a href="mailto:aspcul8r@gmail.com">aspcul8r@gmail.com</a><br>
    Gustavo Campos - <a href="mailto:gustavoc82@me.com">gustavoc82@me.com</a><br>
    Mansa Kiani - <a href="mailto:mahsa.kiani@ieee.org">mahsa.kiani@ieee.org</a><br>
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

##### Answer

**Implementation write-up: Jared**

```csharp
 static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select an option (1, 2, 3, 4, 5) " +
                              "or enter 'x' to quit...");
            Console.WriteLine("1: Add Property");
            Console.WriteLine("2: Calculate Mean");
            Console.WriteLine("3: Calculate Variance");
            Console.WriteLine("4: Calculate Minimum");
            Console.WriteLine("5: Calculate Maximum");
            Console.WriteLine();
        }
```

2. **Implement the adding of property information to the sheet** -. The property information headers are as follows:

a. Size (in square feet)
b. Suburb
c. City
d. Market value

The command line interface already calls a method *"AddPropertyToWorksheet"*, so you will simply have to implement this method.

*Note:* It will be useful here to make use of a counter, which can be stored to the right of the last header, so that you have an easy reference to know how many rows of data are stored in the sheet. This will be useful for the statistical calculations, and to know where each row should be inserted when adding new rows. The counter would be a number stored in a known cell.

3. **Implement statistical methods** -. In the skeleton code you find the following four statistical methods already declared:

a. Mean market value
b. Variance in market value
c. Minimum market value
d. Maximum market value

Your task is to update these methods to perform the correct work based on the data from the sheet. These methods are already called in the command line interface, so you only need to implement the method.

# Conclusion

**Mahsa Task**

# References
