using System;


namespace R5T.T0023
{
    /// <summary>
    /// Indicates whether a server resource is local or remote.
    /// </summary>
    /// <remarks>
    /// See prior work in R5T.Portsmouth: https://github.com/SafetyCone/R5T.Portsmouth/blob/master/source/R5T.Portsmouth/Code/Enumerations/LocalOrRemote.cs
    /// </remarks>
    public enum LocalOrRemote
    {
        Local = 0,
        Remote

        // No unknown value (no ambiguity allowed).
        // No trailing comma since these are the full universe of allowed values.
    }
}
