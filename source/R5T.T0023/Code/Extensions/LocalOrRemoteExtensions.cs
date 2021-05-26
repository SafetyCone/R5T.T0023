using System;

using R5T.T0023;


namespace System
{
    public static class LocalOrRemoteExtensions
    {
        public static T Switch<T>(this LocalOrRemote localOrRemote, Func<T> ifLocal, Func<T> ifRemote)
        {
            // Note, this uses the fact that local-or-remote only has two options.
            var output = localOrRemote == LocalOrRemote.Local
                ? ifLocal()
                : ifRemote();

            return output;
        }
    }
}
