using System;

class Program
{
    static void Main(string[] args)
    {
        bool runAgain = true;
        int _option = 0;
        int _goalType = 0;

        int _totalScore = 0;

        var simple = new Simple();
        var eternal = new Eternal();
        var checklist = new Checklist();

        var goals = new List<Goal>();

        int reportingGoal;

        Console.WriteLine();
        Console.WriteLine("Welcome! Lets set goals together...");

        while (runAgain)
        {
            Simple newSimpleGoal = new Simple();
            Eternal newEternalGoal = new Eternal();
            Checklist newChecklistGoal = new Checklist();

            int listCount = 0;


            Console.WriteLine();
            Console.WriteLine("Your current score is: " + _totalScore);
            Console.WriteLine();

            Console.WriteLine("Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            _option = Int32.Parse(Console.ReadLine());
            switch (_option)
            {
                case 1:
                    Console.WriteLine("Types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goals\n What type of goal would you like to create?: ");
                    _goalType = Int32.Parse(Console.ReadLine());
                    switch (_goalType)
                    {
                        case 1:
                            // Simple Goal
                            newSimpleGoal.GetGoalInfo();
                            goals.Add(newSimpleGoal);
                            break;
                        case 2:
                            // Eternal Goal
                            newEternalGoal.GetGoalInfo();
                            goals.Add(newEternalGoal);
                            break;
                        case 3:
                            // CheckList Goal
                            newChecklistGoal.GetGoalInfo();
                            goals.Add(newChecklistGoal);
                            break;
                        default:
                            Console.WriteLine("Please Select an option 1-3");
                            _goalType = Int32.Parse(Console.ReadLine());
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Goals are:");

                    foreach (var goal in goals)
                    {
                        listCount++;
                        if (goal.ToString() == "Checklist")
                        {
                            Console.WriteLine(listCount + ". " + "[" + goal.GetCheck() + "] " + goal.GetName() + " (" + goal.GetDescription() + ") " + "Completed: " + goal.GetCompletedTimes() + "/"+ goal.GetNeededTimes());
                        }
                        else if (goal.ToString() == "Eternal")
                        {
                            Console.WriteLine(listCount + ". " +"[" + goal.GetCompletedTimes() + "] " + goal.GetName() + " (" + goal.GetDescription() + ") Continuous Goal");
                        }
                        else
                        {
                            Console.WriteLine(listCount + ". " + "[" + goal.GetCheck() + "] " + goal.GetName() + " (" + goal.GetDescription() + ")");
                        }
                    }
                    break;
                case 3:
                    // Save Goals
                    Manager newManager = new Manager();
                    newManager.WriteToFile(goals);
                    break;
                case 4:
                    // Load Goals
                    Manager loadManager = new Manager();
                    string[] lines = loadManager.ReadFromFile();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        if (parts[0] == "Simple")
                        {
                            Simple loadSimpleGoal = new Simple();
                            loadSimpleGoal.SetName(parts[1]);
                            loadSimpleGoal.SetDescription(parts[2]);
                            loadSimpleGoal.SetPointValue(Int32.Parse(parts[3]));
                            loadSimpleGoal.SetCompletedTimes(Int32.Parse(parts[4]));
                            if (Int32.Parse(parts[4]) >= 1)
                            {
                                _totalScore += Int32.Parse(parts[3]);
                            }
                            goals.Add(loadSimpleGoal);
                        }
                        else if (parts[0] == "Eternal")
                        {
                            Eternal loadEternalGoal = new Eternal();
                            loadEternalGoal.SetName(parts[1]);
                            loadEternalGoal.SetDescription(parts[2]);
                            loadEternalGoal.SetPointValue(Int32.Parse(parts[3]));
                            loadEternalGoal.SetCompletedTimes(Int32.Parse(parts[4]));
                            _totalScore += Int32.Parse(parts[3]) * Int32.Parse(parts[4]);

                            goals.Add(loadEternalGoal);
                        }
                        else if (parts[0] == "Checklist")
                        {
                            Checklist loadChecklistGoal = new Checklist();
                            loadChecklistGoal.SetName(parts[1]);
                            loadChecklistGoal.SetDescription(parts[2]);
                            loadChecklistGoal.SetPointValue(Int32.Parse(parts[3]));
                            loadChecklistGoal.SetNeededTimes(Int32.Parse(parts[4]));
                            loadChecklistGoal.SetCompletedTimes(Int32.Parse(parts[5]));
                            loadChecklistGoal.SetBonusPoints(Int32.Parse(parts[6]));
                            // _totalScore = Int32.Parse(parts[7]);
                            if (Int32.Parse(parts[5]) >= Int32.Parse(parts[4]))
                            {
                                _totalScore += Int32.Parse(parts[6]);
                                _totalScore += Int32.Parse(parts[3]) * Int32.Parse(parts[5]);
                            }
                            else
                            {
                                _totalScore += Int32.Parse(parts[3]) * Int32.Parse(parts[5]);

                            }
                            goals.Add(loadChecklistGoal);
                        }
                    }
                    break;
                case 5:
                    // record Event
                    listCount = 0;
                    Console.WriteLine();
                    Console.WriteLine("Goals are:");

                     foreach (var goal in goals)
                    {
                        listCount++;
                        if (goal.ToString() == "Checklist")
                        {
                            Console.WriteLine(listCount + ". " + "[" + goal.GetCheck() + "] " + goal.GetName() + " (" + goal.GetDescription() + ") " + "Completed: " + goal.GetCompletedTimes() + "/"+ goal.GetNeededTimes());
                        }
                        else if (goal.ToString() == "Eternal")
                        {
                            Console.WriteLine(listCount + ". " + "[" + goal.GetCompletedTimes() + "] " + goal.GetName() + " (" + goal.GetDescription() + ") Continuous Goal");
                        }
                        else
                        {
                            Console.WriteLine(listCount + ". " + "[" + goal.GetCheck() + "] " + goal.GetName() + " (" + goal.GetDescription() + ")");
                        }
                    }

                    // let user choose what goal to report on
                    Console.WriteLine("What goal would you like to report on?: ");
                    reportingGoal = Int32.Parse(Console.ReadLine());

                    // add points for completion
                    _totalScore += (goals[reportingGoal - 1].GetPointValue());
                    Console.WriteLine("Great Job! " + goals[reportingGoal - 1].GetPointValue() + " points added to score");
                    Console.WriteLine();
                    Console.WriteLine("Your current score is: " + _totalScore);
                    Console.WriteLine();

                    // conditionals for Checklist goal
                    if (goals[reportingGoal - 1].ToString() == "Checklist")
                    {
                        goals[reportingGoal - 1].SetCompletedTimes(1);
                        _totalScore += goals[reportingGoal - 1].CheckForCompletion();
                    }
                    // conditionals for Eternal goal
                    else if (goals[reportingGoal - 1].ToString() == "Eternal")
                    {
                        goals[reportingGoal - 1].SetCompletedTimes(1);
                    }
                    // conditionals for Simple goal
                    else if (goals[reportingGoal - 1].ToString() == "Simple")
                    {
                        goals[reportingGoal - 1].SetCompletedTimes(1);
                        goals[reportingGoal - 1].SetCheck(true);
                    }
                    break;
                case 6:
                    // quit
                    Console.WriteLine("Have a great day!");
                    runAgain = false;
                    break;
                default:
                    Console.WriteLine("please Select an option 1-6");
                    _option = Int32.Parse(Console.ReadLine());

                    break;
            }
        }
    }
}