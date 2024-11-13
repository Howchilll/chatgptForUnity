加入工程后通过资源包里的Nuget插件下载缺少的库文件
 在chat.cs 的 api = new OpenAIAPI（“”）处，添加openAI的key

核心方法 gptit(string)

调用时的使用示例：

    private string instring="";
    
    private string outstring="";
    
    private async void aichat()
    
    {
    
        outstring = await AIchat.Instance.gptit(instring);
        
    }
    
 通过这个异步的aichat，将instring转递给chatgpt并得到返回的outstring

 如果要打包 先删除open ai api-test这个文件夹
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 After adding the project, download the missing library files through the Nuget plug-in in the resource package

Add the openAI key at api = new OpenAIAPI ("") in chat.cs

Core method gptit(string)

Example of use when calling：

    private string instring="";

    private string outstring="";

    private async void aichat()

    {
    
    outstring = await AIchat.Instance.gptit(instring);

    }
Through this asynchronous aichat, instring is transferred to chatgpt and outstring is returned**
If you want to package, first delete the folder open ai api-test
