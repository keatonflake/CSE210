public class PromptGen{
    string[] prompts = {
        "What was the best thing that happened today?",
        "What was the worst thing that happened today?",
        "What was the most interesting thing I saw or heard today?",
        "What was the most challenging thing I faced today?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What was the most fun thing I did today?",
        "What was the most surprising thing that happened today?",
        "What did I do today that I am proud of?",
        "Describe a small act of kindness you witnessed today,",
        "What was the highlight of your day and why?",
        "Write about a challenge you overcame today.",
        "What made you laugh out loud today?",
        "Reflect on a moment that made you feel grateful today.",
        "Write about a conversation that had a significant impact on you today.",
        "Describe an unexpected surprise that occurred today.",
        "What is something new you learned today, and how does it make you feel?",
        "Write about a decision you made today and how it affected you.",
        "Describe a moment of deep reflection or introspection you had today.",
        "Write about a mistake you made today and what you learned from it.",
        "What was the most challenging aspect of your day?",
        "Describe a moment of joy or happiness that stood out to you today.",
        "Write about a goal or task you accomplished today and how it made you, feel.",
        "Reflect on a moment of frustration or disappointment you experienced today.",
        "Describe a situation where you felt proud of yourself today.",
        "What is one thing you wish you could change about today, and why?",
        "Write about a moment of inspiration or creativity you had today.",
        "Describe a person you interacted with today who had a positive impact on you.",
        "Reflect on a moment of growth or personal development you experienced today.",
    };
    public string RandomPrompt(){
        Random random = new Random();
        int randomNumber = random.Next(31);

        string _prompt = prompts[randomNumber];
        return _prompt;
        
    }
        
}