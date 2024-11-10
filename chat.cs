using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AIchat
{
    private static AIchat instance;

    public static AIchat Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AIchat(); 
            }
            return instance;
        }
    }

    private OpenAIAPI api;
    private List<ChatMessage> messages;

    public AIchat()
    {
        api = new OpenAIAPI("");
        messages = new List<ChatMessage>
        {
            new ChatMessage(ChatMessageRole.System, "You are a teacher teach Ai ")
        };
    }

    public async Task<string> gptit(string instr)
    {
        if (instr.Length < 1) return "bro,You're still paid even if you don't speak";
        if (instr.Length > 100) instr = instr.Substring(0, 100);

        ChatMessage userMessage = new ChatMessage(ChatMessageRole.User, instr);
        messages.Add(userMessage);

        var outmessage = await api.Chat.CreateChatCompletionAsync(new ChatRequest()
        {
            Model = Model.ChatGPTTurbo,
            Temperature = 0.9,
            MaxTokens = 50,
            Messages = messages
        });

        ChatMessage responseMessage = new ChatMessage();
        responseMessage = outmessage.Choices[0].Message;
        messages.Add(responseMessage);
        string outstr= outmessage.Choices[0].Message.Content;
        return outstr;
    }

    }
