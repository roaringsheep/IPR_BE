namespace IPR_BE.Models;

public class QuestionType {

    public int questionTypeId {get; set;}
    public string name {get; set;} = "";

    public ICollection<Question> questions { get; set; } = new List<Question>();
}