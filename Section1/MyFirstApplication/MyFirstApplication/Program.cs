class SampleClass
{
    /*
     * Main() Function is the starting point of this project.
     * Main() Function should return void and must be static.
     */
    static void Main()
    {
        /*
         * System is a Namespace.
         * Inside System Namespace we have pre-defined  class calles Console.
         * Console is a Static Class, which is a member of System namespace.
         * Console class provides a set of properties and methods to perform I/O operations in a Console Application.
         * All the members of Console class are static.
         * Console class is apart of Base Class Library(BCL).
         * Console class contains pre-defined methods like WriteLine(), ReadKey() etc;
         * WriteLine() and ReadKey() is a static methods thats why we are able to call these methods without creating a object for Console class.
         */
        System.Console.WriteLine("Hello World!");
        /*
         * Readkey will wait for a key to press in a keyboard.
         */
        System.Console.ReadKey();
    }
}
