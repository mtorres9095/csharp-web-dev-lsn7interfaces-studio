using System;
namespace SpinningDiscs
{
    public class CD : BasePlayer, IOpticalDisc
    {
        public string Audio { get; set; }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        public CD(string laser, double storage, string audio) : base(laser, storage)
        {
            Audio = audio;
        }
        public void PlayMusic()
        {
            Console.WriteLine($"You are now lsitening song: {Audio}");
        }
        public void SpinDisc()
        {
            Console.WriteLine("CD spins at 200-500 RPMs");
        }
    }
}
