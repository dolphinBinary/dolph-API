# dolphAPI
This is a jetbrains internship test task solution

# Downloading API

1) Requierments: 
 * dotnet5  
Optional: 
 * JetBrains Rider - Recomended (:
 * VisualStudio
 * VisualStudio Code

2) Installing API and use
 *  Download archive
 - Run Program.cs


# API input and output 
Input
 - First, the API will ask you to enter the number of departments in a given bureaucratic organization, it must be a natural number greater than 1
 - Then the configuration of the departments is set, namely, first you set the unconditional or conditional rule, and second you set the block rule Else
 - Then, depending on the specified configuration, the API will either give you a ready-made bypass sheet along with the differences in iterations, or may request additional parameters for a rule, print number or department number

API Output 
   how to read
 - The API will output the department configuration in the format | absoluteOrConditionalRule elseBlockRule | 
 - Natural numbers greater than 0 - prints
 - 0 when department was not visited or is the starting point for moving to the next department
 - -1 stamp is crossed out 
