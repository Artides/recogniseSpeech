using System;
namespace RecogniseSpeech.Domain
{
	public class Text
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public List<string> Phrases { get; set; }
	}
}

