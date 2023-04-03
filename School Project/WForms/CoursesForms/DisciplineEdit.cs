using ClassLibrary;

namespace School_Project.WForms.CoursesForms;

public partial class DisciplineEdit : Form
{
    //
    // Global variables to be used in this windows form
    // Variáveis globais do formulário do Windows
    //
    private readonly Course _courseToEdit;

    public DisciplineEdit(Course courseToEdit)
    {
        InitializeComponent();

        // assigning the parent variable to
        // the local variables to be edited
        _courseToEdit = courseToEdit;
    }


    private void WinFormDisciplineEdit_Load(object sender, EventArgs e)
    {
        //
        // insert data into the boxes
        //
        numericUpDownDisciplineID.Value = _courseToEdit.IdCourse;
        textBoxDisciplineName.Text = _courseToEdit.Name;
        numericUpDownNumberHours.Value = _courseToEdit.WorkLoad;
    }


    private void WinForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) Close();
    }


    private void TextBox_KeyUp(object sender, KeyEventArgs e)
    {
        Console.WriteLine("Testes de Debug");
        /*
         * 
         * https://stackoverflow.com/questions/1876663/how-do-i-allow-ctrl-v-paste-on-a-winforms-textbox
         * 
         * The following code should help:
         * 
         * 
         */
        /*
         *
         * Tests done to discover the right combination
         * 
        if (e.KeyData == (Keys) (86 + 131072))
            MessageBox.Show(
                "Tecla Control + tecla V, via e.KeyData" +
                "\nif (e.KeyData == (Keys) (86+131072))");

        if (e.Modifiers == Keys.Control)
            MessageBox.Show("Tecla Control, via e.Modifiers ");

        if (e.KeyCode == Keys.V)
            MessageBox.Show("Tecla V");
         */

        //if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
        if (e is {Modifiers: Keys.Control, KeyCode: Keys.V})
        {
            ((TextBox) sender).Paste();
            Console.WriteLine("Testes de Debug");
        }
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        _courseToEdit.Name = textBoxDisciplineName.Text;
        _courseToEdit.WorkLoad = (int) numericUpDownNumberHours.Value;

        Close();
    }


    private bool ValidateTextBoxes()
    {
        var valid = true;


        if (string.IsNullOrEmpty(textBoxDisciplineName.Text) ||
            string.IsNullOrWhiteSpace(textBoxDisciplineName.Text))
        {
            MessageBox.Show(
                "Insira um nome valido", "Disciplina",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            textBoxDisciplineName.Select();
        }


        if (numericUpDownNumberHours.Value == 0)
        {
            MessageBox.Show(
                "Insira um valor válido", "Carga horária",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            numericUpDownNumberHours.Select();
        }

        return valid;
    }


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}