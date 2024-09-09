namespace PatientPerson;

public class Patient
{

    public void display()
    {
        Console.WriteLine("PLEASE FILL OUT INFORMATION BELOW IF POSSIBLE");

    }
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
    public int MedicalRecordNumber { get; set; }
    public string FirstName;
    public DateTime Birthday;
    public string BloodType;
    public string CellPhone;
    private object patient;
    private object patientPerson;

    public string Age { get { return getAge(); } }

    private string getAge()
    {
        if (Birthday == DateTime.MinValue)
        {

            return "Unknown";
        }

        return (DateTime.Now.Year - Birthday.Year).ToString();

    }
}