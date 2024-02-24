# Shape Drawer

This console application, named "Shape Drawer," allows users to draw various shapes such as triangles, squares, and rectangles. It provides a simple menu interface where users can choose the shape they want to draw by entering a corresponding number. The program then displays the selected shape on the console. Users have the option to continue drawing additional shapes or exit the application. The shapes drawn include a triangle, a square, and a rectangle, each created using asterisks (*) to represent the outline of the shape.

# 1. Review and Explanation `Main` method:
 ![drow1](/assets/images/drow1.png)

This code initializes a boolean variable `continueDrawing` as true. It then enters a while loop that continues as long as `continueDrawing` remains true. Within the loop, users are prompted to choose a shape to draw from a menu. The program waits for user input and performs actions based on the selected choice, which includes drawing a triangle, square, or rectangle, or exiting the application. After each shape is drawn or the user exits, the program asks if the user wants to continue drawing. If the user chooses to continue (by entering 'y'), the loop continues; otherwise, it ends, and the program terminates.

# 2. Review and Explanation `Main` method:

 ![draw1](/assets/images/draw2.png)
 his part of the code utilizes a switch statement to handle the user's input for selecting a shape to draw. It evaluates the value of `userInput` and executes the corresponding case based on the user's choice:

If the user enters "1", the `DrawTriangle()` function is called to draw a triangle.
If the user enters "2", the `DrawSquare()` function is called to draw a square.
If the user enters "3", the `DrawRectangle()` function is called to draw a rectangle.
If the user enters "4", `continueDrawing` is set to false, indicating that the drawing process should stop, and the program will exit the loop.
If the user enters any other input, a message is displayed indicating that the choice is invalid, prompting the user to select a valid option.

# 3. Review and Explanation `Main` method:
 ![draw2](/assets/images/draw3.png)

After drawing a shape, this section of the code checks if `continueDrawing` is true, indicating that the user has not chosen to exit the application. If `continueDrawing` is true, the program prompts the user with a message asking whether they want to continue drawing.

If the user responds with "y" (case insensitive), `continueDrawing` is set to true, and the loop continues, allowing the user to choose another shape to draw.
If the user responds with anything other than "y", `continueDrawing` is set to false, and the loop terminates, ending the drawing process.
Once the loop ends, the program prints a "Thank you" message indicating the termination of the Shape Drawer application.

# 4. Explanation `DrawTriangle` method:
 ![draw3](/assets/images/draw4.png)
 This code defines the `DrawTriangle()` method, responsible for drawing a triangle shape on the console.

# 5. Explanation `DrawSquare` method:
 ![draw4](/assets/images/draw5.png)
 This code defines the `DrawSquare()` method, responsible for drawing a square shape on the console.

# 6. Explanation `DrawRectangle` method:
 ![draw5](/assets/images/draw6.png)
 This code defines the DrawRectangle() method, responsible for drawing a square shape on the console.

# 7. Demo 
 ![draw5](/assets/images/draw6.png)