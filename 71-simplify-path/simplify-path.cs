public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> pathStack = new Stack<string>();
        var chr = path.ToCharArray();
        var i = 0;
        while(i < chr.Length){
            // skip the /
            while(i < chr.Length && chr[i] == '/'){
                i++;
            }

            // get the directory name
            var builder = new StringBuilder();
            while(i < chr.Length && chr[i] != '/'){
                builder.Append(chr[i]);
                i++;
            }
            var str = builder.ToString();

            if(str == ".."){
                try{
                    pathStack.Pop();
                }catch{}
            }else if(str == "." || str == string.Empty){}
            else{
                pathStack.Push(str);
            }
        }

        return this.GetCanonicalPath(pathStack);
    }

    private string GetCanonicalPath(Stack<string> pathStack){
        string str = string.Empty;
        while(pathStack.Count > 0){
            str = $"/{pathStack.Pop()}" + str;
            Console.WriteLine(str);
        }

        return (str == string.Empty) ? "/" : str;
    }
}