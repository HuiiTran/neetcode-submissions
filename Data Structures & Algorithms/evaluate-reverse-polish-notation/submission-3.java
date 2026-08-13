class Solution {
    public int evalRPN(String[] tokens) {
        Stack<String> stack = new Stack<>();
        int result = 0;
        for(String token: tokens){
            switch(token){
                case "+":
                    {
                        int a = Integer.parseInt(stack.pop());
                        int b = Integer.parseInt(stack.pop());
                        result = a + b;
                        stack.push(Integer.toString(result));
                        break;
                    }
                case "-":
                    {
                        int a = Integer.parseInt(stack.pop());
                        int b = Integer.parseInt(stack.pop());
                        result = b - a;
                        stack.push(Integer.toString(result));
                        break;
                    }
                case "*":
                    {
                        int a = Integer.parseInt(stack.pop());
                        int b = Integer.parseInt(stack.pop());
                        result = a * b;
                        stack.push(Integer.toString(result));
                        break;
                    }
                case "/":
                    {
                        int a = Integer.parseInt(stack.pop());
                        int b = Integer.parseInt(stack.pop());
                        if(a == 0) break;
                        result = b / a;
                        stack.push(Integer.toString(result));
                        break;
                    }
                default:
                    stack.push(token);
                    break;
            }
                
        }
        return Integer.parseInt(stack.peek());
    }
}
