# C# Windows Forms Data Processing Guide

This repository contains a summary and code reference for processing user input in a C# Windows Forms application, based on Chapter 2: Processing Data (*Starting Out with Visual C#*, 6th Edition).

---

## Key Concepts Covered

1. **Reading Input with `TextBox` Controls:**  
   * `TextBox` controls store user input as text via the `.Text` property.
   * Input strings can be parsed to numeric data types using methods like `int.Parse()`, `double.Parse()`, and `decimal.Parse()`.

2. **Variable Declarations & Primitive Data Types:**  
   * Standard C# data types include `string`, `int`, `double`, and `decimal`.
   * Variables must be declared with a compatible data type before storing or processing data.

3. **Clearing Controls:**  
   * Input fields can be emptied using the `.Clear()` method or assigning an empty string (`""`).

4. **Form Navigation & Lifetime:**  
   * Methods like `this.Close()` terminate the active form instance and release allocated UI resources.

---

## Code Implementations

### 1. Processing User Input & Variable Assignment (`creating-variable.png`)

```csharp
// Creating variables to store the user input
string name = txtname.Text;

// Converting the string input to integer
int id = int.Parse(txtid.Text);

// Storing the department input as string
string department = txtdepartment.Text;

// Converting the string input to integer
int semester = int.Parse(txtsemester.Text);

// Displaying the user input in the label
lbloutput.Text = $"Name: {name} ID: {id} Department: {department} Semester: {semester}";

// Clearing the textboxes and label
txtname.Clear();
txtid.Clear();
txtdepartment.Clear();
txtsemester.Clear();
lbloutput.Text = "";

// Closing the exit form
this.Close();