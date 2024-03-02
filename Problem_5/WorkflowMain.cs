namespace Problem_5
{

    class workflowMain
    {

        public static void Main(string[] args)
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();

            List<IActivity> myWorkflow = new List<IActivity>{
                new Activity("Activity 1"),
                new Activity("Activity 2"),
                new Activity("Activity 3"),
                new Activity("Activity 4")
            };

            workflowEngine.run(myWorkflow);

        }
    }
}