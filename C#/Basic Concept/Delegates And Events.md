![示例](https://github.com/HumorLogic/TechDocments/blob/master/C%23/Basic%20Concept/Images/delegate001.jpg)

![示例1](https://github.com/HumorLogic/TechDocments/blob/master/C%23/Basic%20Concept/Images/delegate002.png)

### Program Class
``` C#
namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("这个杀手不太冷");
            VideoEncoder videoEncoder = new VideoEncoder(); //publisher
            MailService mailService = new MailService(); //subscribler

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);

        }
    }

}

```

### Video Class  
``` C#
namespace EventsAndDelegates
{
    class Video
    {
        public string Title { set; get; }

        public Video() { }
        public Video(string title) => Title = title;
    }
}

```

### VideoEncoder Class  
``` C#
using System;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {

        // 1- Define a delegate定义一个委托
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2- Define an event based on that delegate在这个委托上定义事件
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine(video.Title+ " Encoding Video...");
            Thread.Sleep(3000);

            // 3- Raise the event引发事件
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}

```

### MailService Class  
``` C#
using System;

namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncoded(object source, EventArgs eventArgs)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}
```
