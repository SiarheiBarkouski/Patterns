using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> _chars = new Dictionary<char, Character>();

        public CharacterFactory()
        {

        }

        public Character GetCharacter(char key)
        {
            if (!_chars.ContainsKey(key))
            {
                if (key == ' ' || key == '_')
                {
                    _chars.Add(key, new Whitespace());
                }
                else
                {
                    try
                    {
                        _chars.Add(key,
                            new LatinCharacter
                            {
                                Picture = new BitmapImage(
                                    new Uri($"{Environment.CurrentDirectory}//letters//{key}.jpg"))
                            });
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Image not found for Key = {key}");
                        return null;
                    }
                }
            }
            return _chars[key];
        }

    }
}
