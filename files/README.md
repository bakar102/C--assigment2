# Assignment 8: C# File Handling
Project Description
This project is a C# Windows Forms application that demonstrates how to create, read, and delete files, as well as read and delete individual lines of text from a file.
The program uses a text file named output.txt and a ListBox to display information.
Technologies Used
C#
Windows Forms
System.IO for file handling
Visual Studio
Buttons and Their Functions
# Button 1: Create and Write to a File
This button creates a file named output.txt and writes four lines of text into it:
[Hello Ustad]
[my name is Muhammad Ali]
[I am a student]
[At University of Jamhuriya]
It uses File.CreateText() to create the file and StreamWriter to write the text. If the file already exists, its previous contents are overwritten.
#Button 2: Delete the File
This button checks whether output.txt exists. If it exists, the program deletes it and displays a success message. If the file is not found, it displays a message saying so.
The code uses File.Exists() to check for the file and File.Delete() to delete it.
Note: The code opens and closes the file before checking whether it exists. That step is unnecessary for deleting a file and can be removed.
# Button 3: Delete a Selected Item
This button removes the selected line from the ListBox. It then converts the remaining items into a string array and writes them back to output.txt using File.WriteAllLines().
If no item is selected, the program asks the user to select an item.
Note: This button updates the file, but it does not check whether output.txt exists before writing to it. File.WriteAllLines() can create the file if it does not exist.
# Button 4: Read a File Line by Line
This button opens output.txt with StreamReader and reads it one line at a time. Each line is added to the ListBox.
The loop continues until EndOfStream becomes true. The file is then closed.
# Button 5: Read All Lines
This button checks whether output.txt exists. If it does, File.ReadAllLines() reads all its lines into a string array. A foreach loop then adds each line to the ListBox.
# Button 6: Read All Bytes
This button uses File.ReadAllBytes() to read the file's contents as a byte array. It then displays the number of bytes read in the ListBox.
Bytes represent the file's data, rather than individual text lines.
Note: This button will cause an error if output.txt does not exist, because it does not check for the file first.
# Button 7: Read a Block of Characters
This button opens output.txt with StreamReader. It creates a character buffer with space for 20 characters and uses ReadBlock() to read up to 20 characters from the file.
The characters read are converted into a string and displayed in the ListBox. The using statement ensures that the reader is closed when the operation finishes.
# Note: This button will also cause an error if output.txt does not exist.
Important File-Handling Methods
Method or Class
Purpose
File.CreateText()
Creates a text file for writing.
StreamWriter
Writes text to a file.
File.OpenText()
Opens a text file for reading.
StreamReader
Reads text from a file.
File.Exists()
Checks whether a file exists.
File.Delete()
Deletes a file.
File.ReadAllLines()
Reads all text lines into an array.
File.ReadAllBytes()
Reads the file as bytes.
File.WriteAllLines()
Writes an array of lines to a file.
ReadLine()
Reads one line of text.
ReadBlock()
Reads a block of characters.
EndOfStream
Indicates whether the end of the file has been reached.
How to Run the Project
Open the project in Visual Studio.
Make sure the Windows Forms controls and button click events are connected correctly.
# Run the application.
Use Button 1 to create output.txt and write the sample text.
Use Buttons 4, 5, 6, and 7 to try the different reading methods.
Use Button 3 to remove a selected line from the list and update the file.
Use Button 2 to delete the file.
Notes
The file path output.txt is relative. The file is created or searched for in the application's current working directory, which may be the project's output folder when running from Visual Studio.
The ListBox is not cleared before new items are added, so clicking a reading button multiple times may display duplicate entries.
Create the file with Button 1 before using the reading buttons.
Consider adding error handling for cases where the file does not exist or cannot be accessed.
# Conclusion
This project demonstrates basic C# file handling in a Windows Forms application. It shows how to create a text file, write data, read lines and bytes, read a block of characters, delete a selected line, and delete the entire file.
