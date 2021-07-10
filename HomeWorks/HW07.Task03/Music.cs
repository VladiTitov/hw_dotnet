namespace HW07.Task03
{
    class Music : File, IFileActions
    {
        public string Singer { get; set; }
        public string Length { get; set; }
    }
}
