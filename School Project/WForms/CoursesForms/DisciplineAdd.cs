using ClassLibrary;

namespace School_Project.WForms.CoursesForms;

public partial class DisciplineAdd : Form
{
    private int _disciplinesCount;

    public DisciplineAdd()
    {
        InitializeComponent();

        //
        // assign the local variables to is counterpart
        // Global variables from the initial form
        //
    }


    private void DisciplineAdd_KeyDown(object sender, KeyEventArgs e)
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


    private void DisciplineAdd_Load(object sender, EventArgs e)
    {
        //
        // assign the local variables to is counterpart
        // Global variables from the initial form
        //
        if (Courses.ListCourses.Count > 0)
        {
            _disciplinesCount = Courses.ListCourses.Count;
            _disciplinesCount = Courses.GetLastId();
        }


        //
        // make the transparent tab-control transparent
        // transparentTabControl1.MakeTransparent();
        //
        transparentTabControl1.MakeTransparent();

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
    }


    private void ButtonDisciplineSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        Courses.AddCourse(
            (int) numericUpDownDisciplineID.Value,
            textBoxDisciplineName.Text,
            (int) numericUpDownNumberHours.Value,
            0, null
        );

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
        CleanTextBoxes();
    }


    private void ButtonDisciplineCancel_Click(object sender, EventArgs e)
    {
        CleanTextBoxes();
    }


    private void CleanTextBoxes()
    {
        // clean the text a put an value of zero in the numeric box
        textBoxDisciplineName.Clear();
        numericUpDownNumberHours.Value = 0;
    }


    private void UpdateLists()
    {
        //
        // list box has a problem
        //
        // that's why it is necessary to clear the list with a null and
        // then re-associate the class again and that's how it works.
        //
        listBoxDisciplines.DataSource = null;
        listBoxDisciplines.DataSource = Courses.ListCourses;
        //
        // activate this option if you want a specific value else it will use the override method to string
        //listBoxDisciplines.DisplayMember = "Name";
        listBoxDisciplines.ClearSelected();

        Console.WriteLine("Testes de Debug");
    }


    private void UpdateLabelsCounts()
    {
        _disciplinesCount++;
        numericUpDownDisciplineID.Value = _disciplinesCount;
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


    private void ButtonDisciplineRemove_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        var disciplineToDelete = listBoxDisciplines.SelectedItem as Course;

        if (listBoxDisciplines.SelectedItem != null)
        {
            //
            // local variable that will contain the response
            //

            var dialogResult =
                //
                // get the answer, if yes or soups, displaying the message
                //
                MessageBox.Show(
                    "Remover o curso " + $"{disciplineToDelete}",
                    "Apagar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.OK)
            {
                var index = listBoxDisciplines.SelectedIndex;

                Courses.DeleteCourse(index);
                UpdateLists();
            }
        }
        else
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Apagar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
        }

        UpdateLists();
        Console.WriteLine("Testes de Debug");
    }


    private void ButtonDisciplineEdit_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        var disciplineToEdit = listBoxDisciplines.SelectedItem! as Course;

        if (disciplineToEdit != null)
        {
            //
            // open the edit form with the student editing
            //
            DisciplineEdit disciplineEdit = new(disciplineToEdit.IdCourse);
            disciplineEdit.ShowDialog();
        }
        else
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ", "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
        }

        UpdateLists();
    }

    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}