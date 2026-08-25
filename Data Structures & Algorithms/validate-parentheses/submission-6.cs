        public class Solution {
            public bool IsValid(string s) {
                char[] characters = s.ToCharArray();
                Stack<char> stack = new Stack<char>();
                foreach (char letter in characters) {
                    if (letter == '(') {
                        stack.Push(letter);
                    }
                    else if(letter == '{'){
                        stack.Push(letter);
                    }
                    else if (letter == '[') {
                        stack.Push(letter);
                    }
                    else{
                        if (stack.Count == 0) 
                        {
                            return false;
                        }
                            char topChar = stack.Pop();
                            if (letter == ')' && topChar != '(') {
                                return false;
                            }
                            if (letter == '}' && topChar != '{') {
                                return false;
                            }
                            if (letter == ']' && topChar != '[') { 
                                return false;
                            }
                       
                    }
                }
               return stack.Count == 0;
                
            }
        }

