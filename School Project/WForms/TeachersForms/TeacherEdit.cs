using ClassLibrary.Students;
using ClassLibrary.Teachers;

namespace School_Project.WForms.StudentsForms;

public partial class TeacherEdit : Form
{
    //
    // Global variables to be used in this windows form
    // Variáveis globais do formulário do Windows
    //
    private readonly Teacher _teacherToEdit;
    private string _teacherPhoto;


    public TeacherEdit(Teacher teacherToEdit)
    {
        InitializeComponent();

        // assigning the parent variable to
        // the local variables to be edited
        _teacherToEdit = teacherToEdit;

        //DataUpdateValues();
    }

    private void WinForm_Load(object sender, EventArgs e)
    {
        //
        // inserir os dados nas caixas de textos
        //
        numericUpDownStudentID.Value = _teacherToEdit.TeacherId;
        textBoxName.Text = _teacherToEdit.Name;
        textBoxLastName.Text = _teacherToEdit.LastName;
        textBoxAddress.Text = _teacherToEdit.Address;
        textBoxPostalCode.Text = _teacherToEdit.PostalCode;
        textBoxCity.Text = _teacherToEdit.City;
        textBoxPhone.Text = _teacherToEdit.Phone;
        textBoxEmail.Text = _teacherToEdit.Email;

        var activeState =
            _teacherToEdit.Active
                ? CheckState.Checked
                : CheckState.Unchecked;
        checkBoxActive.CheckState = activeState;
        comboBoxGenre.Items.Contains(_teacherToEdit.Genre);

        dateTimePickerBirthDate.Value =
            _teacherToEdit.DateOfBirth.ToDateTime(
                TimeOnly.FromDateTime(DateTime.Now));

        textBoxCC.Text = _teacherToEdit.IdentificationNumber;

        dateTimePickerCCValidDate.Value =
            _teacherToEdit.ExpirationDateIn.ToDateTime(
                TimeOnly.FromDateTime(DateTime.Now));

        textBoxNIF.Text = _teacherToEdit.IdentificationNumber;
        textBoxNationality.Text = _teacherToEdit.Nationality;
        textBoxBirthPlace.Text = _teacherToEdit.Birthplace;

        _teacherPhoto = _teacherToEdit.Photo;
        pictureBoxPhotoDisplay.ImageLocation = _teacherToEdit.Photo;

        numericUpDownTotalWorkLoad.Value =
            _teacherToEdit.GetTotalWorkHourLoad();
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
        if (e is { Modifiers: Keys.Control, KeyCode: Keys.V })
        {
            ((TextBox)sender).Paste();
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
        _teacherPhoto = fileDialog.FileName;
        pictureBoxPhotoDisplay.ImageLocation = fileDialog.FileName;
    }


    private void TextBoxStudentPhone_KeyPress(
        object sender, KeyPressEventArgs e)
    {
        // validating if it's a digit
        if (char.IsDigit(e.KeyChar) || (Keys)e.KeyChar == Keys.Back) return;
        e.Handled = true;
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        Teachers.EditTeacher(
            (int)numericUpDownStudentID.Value,
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
            _teacherPhoto,
            0,
            0,
            null
            //DateOnly.FromDateTime(DateTime.Now)
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
        _teacherPhoto = string.Empty;
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
            MessageBox.Show("Insira o apelido do Professor",
                "Apelido do Professor",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            labelLastName.Select();
        }

        return valid;
    }


}