using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVBridge
{
    class LocalCabelTv : IVideoSource
    {
        const string SOURCE_NAME = "Local Cabel TV";

        string IVideoSource.GetTvGuide()
        {
            return string.Format("Getting TV guide from - {0}", SOURCE_NAME);
        }

        string IVideoSource.PlayVideo()
        {
            return string.Format("Playing - {0}", SOURCE_NAME);
        }
    }
}
