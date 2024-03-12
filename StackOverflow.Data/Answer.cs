namespace StackOverflow.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }

        public List<QuestionAnswer> QuestionAnswers { get; set; }
    }
}