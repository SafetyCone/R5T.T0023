using System;


namespace R5T.T0023
{
    public enum LocalOrRemote
    {
        Local = 0,
        Remote

        // No unknown value (no ambiguity allowed).
        // No trailing comma since these are the full universe of allowed values.
    }
}
