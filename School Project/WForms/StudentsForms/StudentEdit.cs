using ClassLibrary.Students;

namespace School_Project.WForms.StudentsForms;

public partial class StudentEdit : Form
{
    //
    // Global variables to be used in this windows form
    // Variáveis globais do formulário do Windows
    //
    private readonly Student _studentToEdit;
    private string _studentPhoto;


    public StudentEdit(Student studentToEdit)
    {
        InitializeComponent();

        // assigning the parent variable to
        // the local variables to be edited
        _studentToEdit = studentToEdit;

        //DataUpdateValues();
    }

    private void WinForm_Load(object sender, EventArgs e)
    {
        _studentToEdit.CalculateTotalWorkHours();
        _studentToEdit.CountCourses();

        //
        // inserir os dados nas caixas de textos
        //
        numericUpDownStudentID.Value = _studentToEdit.IdStudent;
        textBoxName.Text = _studentToEdit.Name;
        textBoxLastName.Text = _studentToEdit.LastName;
        textBoxAddress.Text = _studentToEdit.Address;
        textBoxPostalCode.Text = _studentToEdit.PostalCode;
        textBoxCity.Text = _studentToEdit.City;
        textBoxPhone.Text = _studentToEdit.Phone;
        textBoxEmail.Text = _studentToEdit.Email;

        var activeState =
            _studentToEdit.Active
                ? CheckState.Checked
                : CheckState.Unchecked;
        checkBoxActive.CheckState = activeState;
        comboBoxGenre.Items.Contains(_studentToEdit.Genre);

        dateTimePickerBirthDate.Value =
            _studentToEdit.DateOfBirth.ToDateTime(
                TimeOnly.FromDateTime(DateTime.Now));

        textBoxCC.Text = _studentToEdit.IdentificationNumber;

        dateTimePickerCCValidDate.Value =
            _studentToEdit.ExpirationDateIn.ToDateTime(
                TimeOnly.FromDateTime(DateTime.Now));

        textBoxNIF.Text = _studentToEdit.IdentificationNumber;
        textBoxNationality.Text = _studentToEdit.Nationality;
        textBoxBirthPlace.Text = _studentToEdit.Birthplace;

        _studentPhoto = _studentToEdit.Photo;
        pictureBoxPhotoDisplay.ImageLocation = _studentToEdit.Photo;

        numericUpDownTotalWorkLoad.Value = _studentToEdit.TotalWorkHours;
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


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ButtonAddPhoto_Click(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new();
        fileDialog.ShowDialog();
        //openFileDialog1.ShowDialog();

        //Students.StudentsList[^1].Photo = fileDialog.FileName;
        _studentPhoto = fileDialog.FileName;
        pictureBoxPhotoDisplay.ImageLocation = fileDialog.FileName;
    }


    private void TextBoxStudentPhone_KeyPress(
        object sender, KeyPressEventArgs e)
    {
        // validating if it's a digit
        if (char.IsDigit(e.KeyChar) || (Keys) e.KeyChar == Keys.Back) return;
        e.Handled = true;
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        Students.EditStudent(
            (int) numericUpDownStudentID.Value,
            textBoxName.Text,
            textBoxLastName.Text,
            textBoxAddress.Text,
            textBoxPostalCode.Text,
            textBoxCity.Text,
            textBoxPhone.Text,
            textBoxEmail.Text,
            true,
            comboBoxGenre.Text,
            DateOnly.FromDateTime(dateTimePickerBirthDate.Value),
            textBoxCC.Text,
            DateOnly.FromDateTime(dateTimePickerCCValidDate.Value),
            textBoxNIF.Text,
            textBoxNationality.Text,
            textBoxBirthPlace.Text,
            _studentPhoto,
            0,
            0,
            DateOnly.FromDateTime(DateTime.Now)
        );

        //
        // initial update
        // count register and the list
        //
        //UpdateLists();
        //UpdateLabelsCounts();
        //ClearTextBoxes();
        Close();
    }


    private void ClearTextBoxes()
    {
        //(int)numericUpDownStudentID.Value;
        textBoxName.Clear();
        textBoxLastName.Clear();
        textBoxAddress.Clear();
        textBoxPostalCode.Clear();
        textBoxCity.Clear();
        textBoxPhone.Clear();
        textBoxEmail.Clear();
        //true;
        //comboBoxGenre.Items.Clear();
        //DateOnly.FromDateTime(dateTimePickerBirthDate.Value);
        textBoxCC.Clear();
        //DateOnly.FromDateTime(dateTimePickerCCValidDate.Value);
        textBoxNIF.Clear();
        textBoxNationality.Clear();
        textBoxBirthPlace.Clear();
        _studentPhoto = string.Empty;
        //0;
        //DateOnly.FromDateTime(DateTime.Now);
        //null;
    }


    private bool ValidateTextBoxes()
    {
        var valid = true;

        if (
            string.IsNullOrEmpty(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Insira o Nome",
                "Nome",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            textBoxName.Select();
        }

        if (
            string.IsNullOrEmpty(textBoxLastName.Text) ||
            string.IsNullOrWhiteSpace(textBoxLastName.Text))
        {
            MessageBox.Show("Insira o apelido do estudante",
                "Apelido do Estudante",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            labelLastName.Select();
        }

        return valid;
    }
}