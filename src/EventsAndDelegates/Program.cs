

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Declare a publisher
            var mailService = new MailService(); // Declare a subscriber

            // Declare the subscription before initiating the call
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
