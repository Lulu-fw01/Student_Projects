using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectLibrary
{
    [Serializable]
    public abstract class Subtask: AbstractTask, IAssignable
    {
        protected List<Artist> artists;
        public List<Artist> Artists { get { return artists; } }
        public Subtask(string name): base(name)
        {
            artists = new List<Artist>();
        }

        public override void CheckDeletedArtists(List<Artist> deletedArtists)
        {
            try
            {
                foreach (var e in deletedArtists)
                {
                    int i = artists.IndexOf(e);
                    if (i != -1)
                        artists.RemoveAt(i);
                }
            }
            catch { }
        }

        public abstract void AddArtist(Artist newArtist);
        public abstract void RemoveArtistAt(int index);

        public override object Current
        {
            get
            {
                if (position == -1 || position >= artists.Count)
                    throw new InvalidOperationException();
                return artists[position];
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return artists.GetEnumerator();
        }

        public override bool MoveNext()
        {
            if (position < artists.Count - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            position = -1;
        }

        public override void UpdateArtistLinks(List<Artist> updatedArtits)
        {
            try
            {
                foreach (var na in updatedArtits)
                {
                    for (int i = 0; i < artists.Count; i++)
                        if (artists[i].Name == na.Name)
                            artists[i] = na;
                }
            }
            catch { }
        }
    }
}
