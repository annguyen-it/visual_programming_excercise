namespace Ex1
{
    class SubjectResult
    {
        public Subject Subject { get; }
        public double Mark { get; }

        public SubjectResult(Subject subject, double mark)
        {
            Subject = subject;
            Mark = mark;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Subject.Name, Subject.Credit, Mark);
        }
    }
}
