using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        List<string> randomComments = new List<string>()
        {
            "Great video, keep up the good work!",
            "This is amazing! I love your content!",
            "Wow, you're really talented!",
            "Fantastic video, I learned so much!",
            "I can't stop watching your videos, they're awesome!",
            "You deserve way more subscribers, your content is top-notch!",
            "This video made my day, thank you!",
            "You're doing an excellent job, keep it up!",
            "I'm always excited to see your new uploads!",
            "Your videos are so inspiring, I feel motivated!",
            "Thumbs up for another fantastic video!",
            "You're a natural, keep making great content!"
        };

        List<string> randomNames = new List<string>()
        {
            "John",
            "Emily",
            "Michael",
            "Sophia",
            "William",
            "Olivia",
            "James",
            "Emma",
            "Benjamin",
            "Ava",
            "Daniel",
            "Mia"
        };

        List<string> randomAuthors = new List<string>()
        {
            "BookwormBibliophile",
            "InkAndInsights",
            "NovelNavigator",
            "ProsePundit",
            "PageTurnerPensmith",
            "WriterlyWisdom",
            "LitLinguist",
            "ScriptScribe",
            "VerseVoyager",
            "StorytellerSupreme",
            "WordSmithy",
            "NarrativeNinja"
        };

              List<string> randomVideoTitles = new List<string>()
        {
            "10 Tips for a Productive Morning Routine",
            "Exploring the Hidden Gems of Paris",
            "Mastering the Art of Photography",
            "Delicious and Healthy Recipes for Busy People",
            "Building a Successful Online Business from Scratch",
            "Incredible Wildlife Encounters in the Amazon Rainforest",
            "Unboxing the Latest Tech Gadgets",
            "The Secrets of Effective Time Management",
            "Travel Vlog: Adventures in Thailand",
            "Discovering Ancient Civilizations: A Journey Through History",
            "Unlocking Creativity: Tips for Writers and Artists",
            "Mindfulness and Meditation: Finding Inner Peace"
        };
        // Create new video and add comments
        for (int i = 0; i < 4; i++)
        {
            Comment newComment = new Comment();
            newComment.SetTitle(randomVideoTitles[GenerateRandomNumber()]);
            newComment.SetAuthor(randomAuthors[GenerateRandomNumber()]);
            newComment.SetLength(5.00);
            newComment.SetName(randomNames[GenerateRandomNumber()]);
            newComment.SetComment(randomComments[GenerateRandomNumber()]);
            newComment.SetComment(randomComments[GenerateRandomNumber()]);
            newComment.SetComment(randomComments[GenerateRandomNumber()]);
            newComment.SetComment(randomComments[GenerateRandomNumber()]);
            videoList.Add(newComment);
        }

        foreach(Comment comment in videoList)
        {
            Console.WriteLine();
            Console.WriteLine(
            comment.GetTitle() + "\n" +
            comment.GetAuthor() + "\n" +
            comment.GetLength() + "\n" +
            comment.GetCommentCount() + "\n" +
            comment.GetName() + "\n" +
            comment.GetComment()
            );
            Console.WriteLine();
        }

        static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 12);
        }


    }
}