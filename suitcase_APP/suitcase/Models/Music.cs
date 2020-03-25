using System;
public class Music : BaseEntity
{
    /// <summary>
    /// Music will have a one to one relationship with Act one act, one song
    /// </summary>
    public string SongTitle { get; set; }
    public string Url { get; set; }
}