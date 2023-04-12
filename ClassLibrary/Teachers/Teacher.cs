using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassLibrary.School;
using Serilog;

namespace ClassLibrary.Teachers;

public class Teacher : INotifyPropertyChanged
{
    public static readonly List<string> Genreslist = new()
        {"Male", "Female", "Non Binary", "Prefer not to say"};


    #region Constructor

    //
    // Constructor for the class and incrementation of the ID
    //

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //
    public Teacher()
    {
        // Generate a unique course ID by incrementing
        // the counter using the Interlocked.Increment method.
        TeacherId = Interlocked.Increment(ref _mCounter);
    }

    #endregion


    public void CalculateTotalWorkHours()
    {
        var totalWorkHourLoad =
            SchoolDatabase
                .GetCoursesForTeacher(TeacherId)?
                .Sum(c => c.WorkLoad);

        if (totalWorkHourLoad is null or 0)
            Log.Warning(
                "The student is not enroll in any course");

        TotalWorkHours = totalWorkHourLoad ?? 0;
    }

    public void CountCourses()
    {
        var CoursesCount =
            SchoolDatabase.GetCoursesForTeacher(TeacherId)?.Count;

        if (CoursesCount is null or 0)
            Log.Warning(
                "The student is not enroll in any course");

        CoursesCount = CoursesCount ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.Enrollments.Count);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.Enrollments.Count);
        */
    }


    #region Attributes

    //
    // Attributes
    //
    private static int _mCounter;


    private string _name;
    private string _lastName;
    private string _address;
    private string _postalCode;
    private string _city;
    private string _phone;
    private string _email;
    private bool _active = true;
    private string _genre;
    private DateOnly _dateOfBirth;
    private string _identificationNumber;
    private DateOnly _expirationDateIn;
    private string _taxIdentificationNumber;
    private string _nationality;
    private string _birthplace;
    private string _photo;

    private int _coursesCount;
    private int _totalWorkHours;

    //private List<Course> _courses = new();

    #endregion


    #region Properties

    public int TeacherId { get; }

    public string Name
    {
        get => _name;
        set
        {
            if (value == _name) return;
            _name = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (value == _lastName) return;
            _lastName = value;
            OnPropertyChanged();
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            if (value == _address) return;
            _address = value;
            OnPropertyChanged();
        }
    }

    public string PostalCode
    {
        get => _postalCode;
        set
        {
            if (value == _postalCode) return;
            _postalCode = value;
            OnPropertyChanged();
        }
    }

    public string City
    {
        get => _city;
        set
        {
            if (value == _city) return;
            _city = value;
            OnPropertyChanged();
        }
    }

    public string Phone
    {
        get => _phone;
        set
        {
            if (value == _phone) return;
            _phone = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (value == _email) return;
            _email = value;
            OnPropertyChanged();
        }
    }

    public bool Active
    {
        get => _active;
        set
        {
            if (value == _active) return;
            _active = value;
            OnPropertyChanged();
        }
    }

    public string Genre
    {
        get => _genre;
        set
        {
            if (value == _genre) return;
            _genre = value;
            OnPropertyChanged();
        }
    }

    public DateOnly DateOfBirth
    {
        get => _dateOfBirth;
        set
        {
            if (value.Equals(_dateOfBirth)) return;
            _dateOfBirth = value;
            OnPropertyChanged();
        }
    }

    public string IdentificationNumber
    {
        get => _identificationNumber;
        set
        {
            if (value.Equals(_identificationNumber)) return;
            _identificationNumber = value;
            OnPropertyChanged();
        }
    }

    public DateOnly ExpirationDateIn
    {
        get => _expirationDateIn;
        set
        {
            if (value.Equals(_expirationDateIn)) return;
            _expirationDateIn = value;
            OnPropertyChanged();
        }
    }

    public string TaxIdentificationNumber
    {
        get => _taxIdentificationNumber;
        set
        {
            if (value.Equals(_taxIdentificationNumber)) return;
            _taxIdentificationNumber = value;
            OnPropertyChanged();
        }
    }

    public string Nationality
    {
        get => _nationality;
        set
        {
            if (value == _nationality) return;
            _nationality = value;
            OnPropertyChanged();
        }
    }

    public string Birthplace
    {
        get => _birthplace;
        set
        {
            if (value == _birthplace) return;
            _birthplace = value;
            OnPropertyChanged();
        }
    }

    public string Photo
    {
        get => _photo;
        set
        {
            if (value == _photo) return;
            _photo = value;
            OnPropertyChanged();
        }
    }


    public int CoursesCount
    {
        get => _coursesCount;
        set
        {
            if (value == _coursesCount) return;
            _coursesCount = value;
            OnPropertyChanged();
        }
    }

    public int TotalWorkHours
    {
        get => _totalWorkHours;
        internal set
        {
            if (value == _totalWorkHours) return;
            _totalWorkHours = value;
            OnPropertyChanged();
        }
    }

    #endregion


    #region Methods

    public int GetTotalWorkHourLoad()
    {
        var totalWorkHourLoad =
            SchoolDatabase.GetCoursesForTeacher(TeacherId)?
                .Sum(c => c.WorkLoad);

        if (totalWorkHourLoad is null or 0)
            Log.Warning(
                "The student is not enroll in any course");

        TotalWorkHours = totalWorkHourLoad ?? 0;
        return totalWorkHourLoad ?? 0;
    }


    public override string ToString()
    {
        // return base.ToString();
        // return $"{IdStudent,5} | {FullName()} | {Phone} - {Address}";
        // return $"{IdStudent,3} | {Name} {LastName} | {Phone} - {Address}";
        return $"{TeacherId,3} | {Name} {LastName}";
    }

    #endregion


    #region PropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value,
        [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}