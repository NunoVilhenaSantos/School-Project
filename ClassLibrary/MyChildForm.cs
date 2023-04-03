namespace ClassLibrary;

// Example child form class
public class MyChildForm : Form, IChildForm
{
    public void ShowForm()
    {
        // Set form properties
        TopLevel = false;
        FormBorderStyle = FormBorderStyle.None;
        Dock = DockStyle.Fill;
        BringToFront();
        Show();
    }
}