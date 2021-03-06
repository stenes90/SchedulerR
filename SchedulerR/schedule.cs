﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Itenso.TimePeriod;
using SchedulerR.Models;

namespace SchedulerR.Models
{
    public static class Schedule
    {
        //private ApplicationDbContext _context;
        //private MatchGenerator _generator;

        //public Schedule()
        //{
        //    _context = new ApplicationDbContext();
        //    _generator = new MatchGenerator(_context);
        //}


        //private ApplicationDbContext _context;
        //public Schedule()
        //{
        //    _context = new ApplicationDbContext();
        //}
        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}
        public static TimeRange Timerange(Dtos.Match match)
        {
            var timeRange = new TimeRange();
            timeRange.Start = match.StartTime;
            timeRange.End = match.EndTime;


            return timeRange;
        }





        public static Dtos.Tournament ScheduleMatches(Dtos.Tournament tournament)
        {
            //var tournamentJsonString = "{\"Id\":0,\"StartDate\":\"2020-09-30T00:00:00\",\"EndDate\":\"2020-10-03T00:00:00\",\"Courts\":[{\"Id\":11,\"Name\":\"Court 1\"},{\"Id\":12,\"Name\":\"Court 2\"},{\"Id\":13,\"Name\":\"Court 3\"}],\"Classes\":[{\"Id\":1144,\"Name\":\"Klasa 1\"},{\"Id\":1145,\"Name\":\"Klasa 2\"}],\"Matches\":[{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":1,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":2,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":3,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":4,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":4,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":4,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":4,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":4,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":4,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":5,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":5,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":5,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":5,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":5,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null},{\"Id\":0,\"Round\":5,\"ClassId\":null,\"Class\":null,\"Challenger\":null,\"Challenged\":null}]}";
            //Tournament tournament = Newtonsoft.Json.JsonConvert.DeserializeObject<Tournament>(tournamentJsonString);
            //var _generator = new MatchGenerator();
            //var matches = _generator.GenerateMatches(tournament);
            var matches = tournament.Matches.ToList();

            for (int i = 0; i < matches.Count; i++)
            {
                matches[i].Id = i + 1;
            }

            var scheduledMatches = matches.Where(c => c.IsScheduled == true).ToList();
            var notScheduledMatches = matches.Where(c => c.IsScheduled == false).ToList();
            int scheduleIndex = 1;
            var listOfScheduledMatches = new List<Dtos.Match>();
            foreach (var actualDate in tournament.PlayingDates)
            {
                scheduledMatches = matches.Where(c => c.IsScheduled == true).ToList();
                notScheduledMatches = matches.Where(c => c.IsScheduled == false).ToList();
                var listOfCourts = actualDate.Courts.ToList();
                var endTime = actualDate.EndTime;
                //var classesForDate = actualDate.Classes;
                //var matchesForDate = matches.Where(c => c.Class.PlayingDates.Contains(actualDate)).ToList()
                //    .Where(x => x.IsScheduled == false).ToList();

                var matchIndex = 0;
                foreach (var match in notScheduledMatches)
                {
                    matchIndex++;
                    var matchClass = tournament.Classes.SingleOrDefault(c => c.Id == match.ClassId);
                    match.Timerange = Timerange(match);
                    match.matchScheduleIndex = matchIndex;
                    var nextAvailableTimeForClassMatch = new DateTime();
                    try
                    {
                        //ClassId was Class before change
                        var lastScheduledMatchFromSameClassForPreviousRound =
                        listOfScheduledMatches.Where(c => c.Round == (match.Round - 1))
                        .Where(x => x.ClassId == (match.ClassId)).Where(z => z.PlayingDate.Id == actualDate.Id).ToList().Last();
                        nextAvailableTimeForClassMatch = lastScheduledMatchFromSameClassForPreviousRound.EndTime.AddMinutes(matchClass.BreakBetweenMatches);
                        //nextAvailableTimeForClassMatch = lastScheduledMatchFromSameClassForPreviousRound.EndTime.AddMinutes(match.Class.BreakBetweenMatches);
                    }
                    catch (Exception)
                    {
                    }
                    var listOfStartTimesForEachCourt = new List<DateTime>();
                    foreach (var court in actualDate.Courts)
                    {
                        var checkTime = new TimeRange();
                        checkTime.Start = actualDate.StartTime.AddMinutes(1);
                        checkTime.End = checkTime.Start.AddSeconds(16);

                        //var scheduledMatchesForCourt = court.Matches.Where(c => c.IsScheduled).Where(x => x.PlayingDate == actualDate).ToList();
                        var scheduledMatchesForCourt = matches.Where(c=>c.CourtId == court.Id).Where(c => c.IsScheduled).Where(x => x.PlayingDate == actualDate).ToList();
                        var listOfMatchTimeRangesForCourt = new List<TimeRange>();
                        var courtName = court.Name;
                        foreach (var item in scheduledMatchesForCourt)
                        {
                            listOfMatchTimeRangesForCourt.Add(Timerange(item));
                        }

                        while (checkTime.End.TimeOfDay < actualDate.EndTime.TimeOfDay)
                        {
                            if (scheduledMatchesForCourt.Count == 0)
                            {
                                match.StartTime = actualDate.StartTime;
                                listOfStartTimesForEachCourt.Add(match.StartTime);
                                break;
                            }
                            else
                            {
                                bool overlap = false;
                                for (int i = 0; i < listOfMatchTimeRangesForCourt.Count; i++)
                                {
                                    bool checkTimeRangeIntersectWithScheduledMatch = listOfMatchTimeRangesForCourt[i].IntersectsWith(checkTime);
                                    if (checkTimeRangeIntersectWithScheduledMatch)
                                    {
                                        overlap = true;
                                        break;
                                    }
                                }


                                if (overlap)
                                {
                                    checkTime.End = checkTime.End.AddMinutes(5);
                                    checkTime.Start = checkTime.Start.AddMinutes(5);
                                }
                                else if (checkTime.Start < nextAvailableTimeForClassMatch)
                                {
                                    checkTime.End = checkTime.End.AddMinutes(5);
                                    checkTime.Start = checkTime.Start.AddMinutes(5);
                                }
                                else
                                {
                                    match.StartTime = checkTime.Start.AddMinutes(-1);
                                    listOfStartTimesForEachCourt.Add(match.StartTime);
                                    break;
                                }
                            }

                        }
                    }

                    if (listOfStartTimesForEachCourt.Count == 0)
                    {
                        break;
                    }

                    var noOfscheduledMatches = matches.Where(c => c.IsScheduled == true).ToList().Count;
                    var listofscheduledddd = matches.Where(c => c.IsScheduled == true).ToList();
                    var listOfCourtss = tournament.Courts.ToList();
                    var listofMatchesforCourt1 = listofscheduledddd.Where(c => c.CourtId == listOfCourtss[0].Id);
                    var matchesRangesForCourt1 = new List<TimeRange>();
                    foreach (var item in listofMatchesforCourt1)
                    {
                        matchesRangesForCourt1.Add(Timerange(item));
                    }
                    var listofMatchesforCourt2 = listofscheduledddd.Where(c => c.CourtId == listOfCourtss[1].Id);
                    var matchesRangesForCourt2 = new List<TimeRange>();
                    foreach (var item in listofMatchesforCourt2)
                    {
                        matchesRangesForCourt2.Add(Timerange(item));
                    }
                    var smallestDate = listOfStartTimesForEachCourt.Min();
                    var indexOfSmallest = listOfStartTimesForEachCourt.IndexOf(smallestDate);
                    match.CourtId = listOfCourts[indexOfSmallest].Id;
                    //var courtNameeee = match.Court.Name.ToString();
                    //var classNameee = match.Class.Name.ToString();
                    ////listOfCourts[indexOfSmallest].Matches.Add(match);
                    match.PlayingDate = actualDate;
                    //match.StartTime.Date = actualDate.Date;
                    ////actualDate.Matches.Add(match);
                    match.StartTime = smallestDate;
                    //match.EndTime = match.StartTime.AddMinutes(match.Class.MatchDuration);
                    match.EndTime = match.StartTime.AddMinutes(matchClass.MatchDuration);
                    match.MatchDuration = matchClass.MatchDuration;
                    match.IsScheduled = true;
                    ////match.Tournament = tournament;

                    listOfScheduledMatches.Add(match);

                    var matchesForCourtThatNeedToBeMoved = matches.Where(c => c.CourtId == listOfCourts[indexOfSmallest].Id).ToList().Where(x => x.StartTime > match.StartTime).ToList();
                    if (matchesForCourtThatNeedToBeMoved.Count > 0)
                    {
                        var listOfMatchesTimeRanges = new List<TimeRange>();
                        var listOfIntersectMatchesTimeRanges = new List<TimeRange>();

                        foreach (var item in matchesForCourtThatNeedToBeMoved)
                        {
                            listOfMatchesTimeRanges.Add(Timerange(item));
                        }

                        foreach (var item in listOfMatchesTimeRanges)
                        {
                            if (item.IntersectsWith(Timerange(match)))
                            {
                                listOfIntersectMatchesTimeRanges.Add(item);
                            }
                        }

                        if (listOfIntersectMatchesTimeRanges.Count > 0)
                        {
                            var firstIntersectedMatch = listOfIntersectMatchesTimeRanges.First();
                            var IntersectionInterval = Timerange(match).Duration - (firstIntersectedMatch.Start.TimeOfDay - match.StartTime.TimeOfDay);
                            foreach (var item in matchesForCourtThatNeedToBeMoved)
                            {
                                item.EndTime = item.EndTime.AddMinutes(IntersectionInterval.TotalMinutes);
                                item.StartTime = item.StartTime.AddMinutes(IntersectionInterval.TotalMinutes);
                            }
                        }





                    }




                }
            }
            return tournament;
        }



    }
}
