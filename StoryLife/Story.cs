namespace Undertale
{
    public class Story
    {
        private List<Frame> _frames = new List<Frame>();

        public Story(List<Frame> frames)
        {
            _frames = frames;
        }

        public List<Frame> Frames
        {
            get
            {
                return _frames;
            }
        }
    }
}
