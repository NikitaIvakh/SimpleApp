# SimpleApp

### The main component of the project is the WPF application window, which contains buttons and a text field for input and display of numbers and operations. When buttons with numbers or operators are pressed, the corresponding value is added to the current expression in the text field. When the "=" button is pressed, the expression is evaluated using the DataTable class, and the result is displayed in the text field.

### To handle button click events, the Button_Click method is used, which is defined in the code. In this method, it checks which button was clicked and performs the corresponding actions based on that. For example, if the "AC" (clear) button is pressed, the text field is cleared. If the "=" button is pressed, the expression is calculated using the DataTable class, and the result is displayed in the text field.

### In summary, the WPF calculator is a simple project that demonstrates the basic principles of GUI development using WPF and allows users to perform basic arithmetic operations through a graphical interface.