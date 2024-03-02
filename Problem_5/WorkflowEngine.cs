namespace Problem_5
{
    public class WorkflowEngine
    {
        public void run(List<IActivity> workflow)
        {

            foreach (var activity in workflow)
            {
                activity.execute();
            }
        }
    }
}