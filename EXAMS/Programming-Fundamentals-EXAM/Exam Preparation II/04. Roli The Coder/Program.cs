using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventsRegex = new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participant>(?:@[a-zA-Z0-9'-]+\s*)*)");
            var events = new Dictionary<int, Event>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code") break;
                var eventMatch = eventsRegex.Match(line);

                if (!eventMatch.Success)
                {
                    continue;
                }

                var id = int.Parse(eventMatch.Groups["id"].Value);
                var eventName = eventMatch.Groups["eventName"].Value;
                var participantStr = eventMatch.Groups["participant"].Value;
                var participants = new List<string>();
                if (participantStr.Length > 0)
                {
                    participants.AddRange(participantStr.Split(new char[] {' '}
                        , StringSplitOptions.RemoveEmptyEntries));
                }

                if (!events.ContainsKey(id))
                {
                    var  @event = new Event()
                    {
                       Name = eventName,
                       Participant = participants
                    };
                    events[id] = @event;
                }
                else if (events[id].Name == eventName)
                {
                    events[id].Participant.AddRange(participants);  
                }
            }
            foreach (var @event in events)
            {
                @event.Value.Participant = @event.Value.Participant
                    .Distinct()
                    .OrderBy(a =>a).ToList();
            }
            var sortedEvents = events.OrderByDescending(a => a.Value.Participant.Count)
                .ThenBy(a => a.Value.Name)
                .Select(a => a.Value)
                .ToArray();
            foreach (var sortedEvent in sortedEvents)
            {
                Console.WriteLine($"{sortedEvent.Name} - {sortedEvent.Participant.Count}");
                foreach (var ev in sortedEvent.Participant)
                {
                    Console.WriteLine($"{ev}");   
                }
            }
        }
    }

    class Event
    {
        public string Name { get; set; }
        public List<string> Participant { get; set; }
    }
}
