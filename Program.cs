using System;
namespace MusicArray
{
    class Program
    {
        enum MusicGenre
        {
            Pop,
            Indie,
            Emo,
            Folk,
            Rock,
            Country
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private MusicGenre? MusicGenre;

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setMusicGenre(MusicGenre musicgenre)
            {
                MusicGenre = musicgenre;
            }
            //display method
            public string Display()
            {
                return "Song Title: " + Title + "\n Artist " + Artist +
                    "\n Album: " + Album + "\n Song Length: " + Length + "\n Music Genre: " + MusicGenre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int songAmt = int.Parse(Console.ReadLine());

            Music[] songs = new Music[songAmt];

            try
            {
                for (int i = 0; i < songAmt; i++)
                {
                    Console.WriteLine("What is the title of your favorite song?");
                    songs[i].setTitle(Console.ReadLine());

                    Console.WriteLine("What is the artist's name?");
                    songs[i].setArtist(Console.ReadLine());

                    Console.WriteLine("What album is the song from?");
                    songs[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("What is the song length in minutes?");
                    songs[i].setLength(double.Parse(Console.ReadLine()));

                    Console.WriteLine("What is the music genre?");
                    Console.WriteLine("P - Pop\nI - Indie\nE - Emo\nF - Folk\nR - Rock\nC - Country");
                    MusicGenre tempMusicGenre = MusicGenre.Pop;
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'P':
                            tempMusicGenre = MusicGenre.Pop;
                            break;
                        case 'I':
                            tempMusicGenre = MusicGenre.Indie;
                            break;
                        case 'E':
                            tempMusicGenre = MusicGenre.Emo;
                            break;
                        case 'F':
                            tempMusicGenre = MusicGenre.Folk;
                            break;
                        case 'R':
                            tempMusicGenre = MusicGenre.Rock;
                            break;
                        case 'C':
                            tempMusicGenre = MusicGenre.Country;
                            break;
                    }
                    songs[i].setMusicGenre(tempMusicGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i=0; i < songAmt; i++)
                {
                    Console.WriteLine($"Song #{i+1}: {songs[i].Display()}\n");
                }
            }
        }
    }
}