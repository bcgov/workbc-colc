using ColcDataLayerWcfService.Caching;
using ColcDataLayerWcfService.CustomExceptions;
using ColcDataLayerWcfService.KenticoDataAccess;
using ColcDataLayerWcfService.KenticoDataAccess.Models;
using ColcDataLayerWcfService.Models.ExternalLinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.Controllers
{
    public class ExternalLinksController
    {
        public ICacheProvider Cache { get; set; }
        public IEnumerable<object> GetHardcodedExternalLinksData { get; private set; }

        public ExternalLinksController()
            : this(new DefaultCacheProvider())
        { }

        public ExternalLinksController(ICacheProvider cacheProvider)
        {
            this.Cache = cacheProvider;
        }


        /// <summary>
        /// Gets external links from the database.
        /// </summary>
        /// <param name="skin">visual style for a particular site (e.g. welcomebc)</param>
        /// <returns>List of external links for the skin</returns>
        /// With the deprecation of the KCMS database, this was hardcoded for the interim until it can be migrated to the WorkBC SSoT or somewhere
        /// the following SQL was used to extract it from the database - left here in case it is useful later
        ///--new ExternalLinksModels 
        ///--{ 
        ///--    Section = "",
        ///--    LinkDescription = "",
        ///--    LinkText = "",
        ///--    LinkURL = "",
        ///--    SortOrder = 0,
        ///--},
        ///select*
        ///from COLC_ExternalLinks
        ///order by Section, SortOrder
        ///select 
        ///	'new ExternalLinksModels' + CHAR(13)+CHAR(10) +
        ///	'{' + CHAR(13)+CHAR(10)+
        ///	'    Section = "' + Section + '",' + CHAR(13)+CHAR(10)+
        ///	'    LinkDescription = "' + LinkDescription + '",' + CHAR(13)+CHAR(10)+
        ///	'    LinkText = "' + LinkText + '",' + CHAR(13)+CHAR(10)+
        ///	'    LinkURL = "' + LinkURL + '",' + CHAR(13)+CHAR(10)+
        ///	'    SortOrder = ' + CAST(SortOrder as varchar(20)) + ',' + CHAR(13)+CHAR(10)+
        ///	'},' + CHAR(13)+CHAR(10)+
        ///	''
        ///from COLC_ExternalLinks
        ///where skin = 'welcomebc'
        ///order by Section, SortOrder
        ///select
        ///	'new ExternalLinksModels' + CHAR(13)+CHAR(10) +
        ///	'{' + CHAR(13)+CHAR(10)+
        ///	'    Section = "' + Section + '",' + CHAR(13)+CHAR(10)+
        ///	'    LinkDescription = "' + LinkDescription + '",' + CHAR(13)+CHAR(10)+
        ///	'    LinkText = "' + LinkText + '",' + CHAR(13)+CHAR(10)+
        ///	'    LinkURL = "' + LinkURL + '",' + CHAR(13)+CHAR(10)+
        ///	'    SortOrder = ' + CAST(SortOrder as varchar(20)) + ',' + CHAR(13)+CHAR(10)+
        ///	'},' + CHAR(13)+CHAR(10)+
        ///	''
        ///from COLC_ExternalLinks
        ///where skin != 'welcomebc'
        ///order by Section, SortOrder


        public IEnumerable<ExternalLinksModels> GetExternalLinks(string skin)
        {
            switch (skin) 
            {
                case "welcomebc":
                    return new List<ExternalLinksModels>
                    {
                        new ExternalLinksModels
                        {
                            Section = "newcomers",
                            LinkDescription = "Moving to a new country or province can be challenging. The B.C. Newcomers' Guide can provide you the information you and your family need to settle quickly in B.C.",
                            LinkText = "B.C. Newcomers' Guide",
                            LinkURL = "https://www.welcomebc.ca/Start-Your-Life-in-B-C/Newcomers-Guides.",
                            SortOrder = 1,
                        },
                        new ExternalLinksModels
                        {
                            Section = "newcomers",
                            LinkDescription = "WelcomeBC Career Profiles can help you understand how your occupation is practiced in B.C. Learn the steps you can take to get qualified.",
                            LinkText = "Career Profiles for Immigrants",
                            LinkURL = "https://www.welcomebc.ca/Work-or-Study-in-B-C/Your-Career-in-B-C",
                            SortOrder = 2,
                        },
                        new ExternalLinksModels
                        {
                            Section = "newcomers",
                            LinkDescription = "The BC Provincial Nominee Program (BC PNP) provides a pathway to settle permanently in B.C. See if you're eligible for the program.",
                            LinkText = "BC Provincial Nominee Program",
                            LinkURL = "http://www.welcomebc.ca/Immigrate/About-the-BC-PNP.aspx",
                            SortOrder = 3,
                        },
                        new ExternalLinksModels
                        {
                            Section = "residents",
                            LinkDescription = "Discover labour market details about B.C. and its seven economic development regions, including 10 year employment outlooks and more.",
                            LinkText = "B.C. and Regional Profiles",
                            LinkURL = "https://www.workbc.ca/Labour-Market-Information/Regional-Profiles.aspx",
                            SortOrder = 1,
                        },
                        new ExternalLinksModels
                        {
                            Section = "residents",
                            LinkDescription = "Discover what drives B.C.'s economy, explore industries and learn about the province’s regions, population and 10-year employment outlook.",
                            LinkText = "Research the Labour Market",
                            LinkURL = "https://www.workbc.ca/research-labour-market",
                            SortOrder = 2,
                        },
                        new ExternalLinksModels
                        {
                            Section = "residents",
                            LinkDescription = "Find a job using the WorkBC Job Board. Search thousands of job postings throughout B.C. by salary, industry and region.",
                            LinkText = "WorkBC Job Board",
                            LinkURL = "https://www.workbc.ca/Jobs-Careers/Find-Jobs.aspx",
                            SortOrder = 3,
                        },
                    };
                case "workbc":
                default:
                    return new List<ExternalLinksModels>
                    {
                        new ExternalLinksModels
                        {
                            Section = "newcomers",
                            LinkDescription = "Moving to a new country or province can be challenging. The B.C. Newcomers' Guide can provide you the information you and your family need to settle quickly in B.C.",
                            LinkText = "B.C. Newcomers' Guide",
                            LinkURL = "https://www.welcomebc.ca/Start-Your-Life-in-B-C/Newcomers-Guides",
                            SortOrder = 1,
                        },
                        new ExternalLinksModels
                        {
                            Section = "newcomers",
                            LinkDescription = "Can't decide which career is right for you?  Browse our career profiles to learn job details and outlooks for 500 different occupations.",
                            LinkText = "Career Profiles",
                            LinkURL = "https://www.workbc.ca/Jobs-Careers/Explore-Careers.aspx",
                            SortOrder = 2,
                        },
                        new ExternalLinksModels
                        {
                            Section = "newcomers",
                            LinkDescription = "Find your fit in B.C.'s growing economy. Learn which occupations are projected to have a large number of openings between 2022-2032.",
                            LinkText = "High Opportunity Occupations",
                            LinkURL = "https://www.workbc.ca/Labour-Market-Industry/High-Opportunity-Occupations.aspx",
                            SortOrder = 3,
                        },
                        new ExternalLinksModels
                        {
                            Section = "residents",
                            LinkDescription = "Discover labour market details about B.C. and its seven economic development regions, including 10 year employment outlooks and more.",
                            LinkText = "B.C. and Regional Profiles",
                            LinkURL = "https://www.workbc.ca/Statistics/Regional-Profiles.aspx",
                            SortOrder = 1,
                        },
                        new ExternalLinksModels
                        {
                            Section = "residents",
                            LinkDescription = "Discover what drives B.C.'s economy, explore industries and learn about the province’s regions, population and 10-year employment outlook.",
                            LinkText = "Research the Labour Market",
                            LinkURL = "https://www.workbc.ca/research-labour-market",
                            SortOrder = 2,
                        },
                        new ExternalLinksModels
                        {
                            Section = "residents",
                            LinkDescription = "Find a job using the WorkBC Job Board. Search thousands of job postings throughout B.C. by salary, industry and region.",
                            LinkText = "WorkBC Job Board",
                            LinkURL = "https://www.workbc.ca/Jobs-Careers/Find-Jobs.aspx",
                            SortOrder = 3,
                        },
                    };
            }
        }       
    }
}