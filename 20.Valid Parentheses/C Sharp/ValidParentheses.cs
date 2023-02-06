            Stack<char> stackBracket = new Stack<char>();
            foreach(char bracketChar in s)
            {
                switch (bracketChar)
                {
                    case '(':
                    case '[':
                    case '{':
                        stackBracket.Push(bracketChar);
                        break;
                    case ')':
                        break;
                    case ']':

                        break;
                    case '}':

                        break;

                }
            }
            return false;