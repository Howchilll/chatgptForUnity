加入工程后通过资源包里的Nuget插件下载缺少的库文件
 在chat.cs 的 api = new OpenAIAPI（“”）处，添加openAI的key

核心方法 chatit

调用时的使用示例：

    private string instring="";
    
    private string outstring="";
    
    private async void aichat()
    
    {
    
        outstring = await AIchat.Instance.gptit(instring);
        
    }
    
 通过这个异步的aichat，将instring转递给chatgpt并得到返回的outstring
    
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 After adding the project, download the missing library files through the Nuget plug-in in the resource package

Add the openAI key at api = new OpenAIAPI ("") in chat.cs

Core method chatit

Example of use when calling：

    private string instring="";

    private string outstring="";

    private async void aichat()

    {
    
    outstring = await AIchat.Instance.gptit(instring);

    }
Through this asynchronous aichat, instring is transferred to chatgpt and outstring is returned**
