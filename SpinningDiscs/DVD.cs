using System;
namespace SpinningDiscs
{
    public class DVD : BasePlayer, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public string Video { get; set; }

        public DVD(string laser, double storage, string video) : base(laser, storage)
        {

            Video = video;

        }

        public void PlayMovie()
        {
            Console.WriteLine($"You are now watching video: {Video}");
        } 
        public void SpinDisc()
        {
            Console.WriteLine("DVD spins at 570-1600 RPMs");
        }
    }



}



