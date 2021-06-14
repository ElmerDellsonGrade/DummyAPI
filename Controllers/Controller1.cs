//ELMER'S TEST METHODS
[HttpGet, Route("v1/users/gethelloworld")]
public string GetHelloWorld()
{
    return "Hello World!";
}