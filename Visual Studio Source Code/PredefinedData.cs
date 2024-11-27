using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellnessApp.Items;

namespace WellnessApp.Database.Services
{
    public static class PredefinedData
    {
        // Predefined Theme data
        public static List<Theme> Themes => new List<Theme>
        {
            new Theme { ThemeId = 1, Name = "Fitness", Description = "", Status = "Inactive"},
            new Theme { ThemeId = 2, Name = "Studying", Description = "", Status = "Inactive" },
            new Theme { ThemeId = 3, Name = "Language", Description = "", Status = "Inactive" },
            new Theme { ThemeId = 4, Name = "Instrument", Description = "", Status = "Inactive"},
            new Theme { ThemeId = 5, Name = "Mental Health", Description = "", Status = "Inactive" }
        };

        // Predefined Category data
        public static List<Category> Categories => new List<Category>
        {
            new Category { CategoryId = 1, Name = "Strength Training", Description = "", ParentThemeId = 1, Status = "Inactive" },
            new Category { CategoryId = 2, Name = "Endurance Training", Description = "", ParentThemeId = 1, Status = "Inactive" },
            new Category { CategoryId = 3, Name = "Fliexibility Training", Description = "", ParentThemeId = 1, Status = "Inactive" },

            new Category { CategoryId = 4, Name = "General Study Tips", Description = "", ParentThemeId = 2, Status = "Inactive" },
            new Category { CategoryId = 5, Name = "Personalization and Mindset", Description = "", ParentThemeId = 2, Status = "Inactive" },
            new Category { CategoryId = 6, Name = "Exam Preparation", Description = "", ParentThemeId = 2, Status = "Inactive" },

            new Category { CategoryId = 7, Name = "Learning Strategies", Description = "", ParentThemeId = 3, Status = "Inactive" },
            new Category { CategoryId = 8, Name = "Listening", Description = "", ParentThemeId = 3, Status = "Inactive" },
            new Category { CategoryId = 9, Name = "Reading/Writing", Description = "", ParentThemeId = 3, Status = "Inactive" },

            new Category { CategoryId = 10, Name = "Technique and Fundamentals", Description = "", ParentThemeId = 4, Status = "Inactive" },
            new Category { CategoryId = 11, Name = "Repertoire", Description = "", ParentThemeId = 4, Status = "Inactive" },
            new Category { CategoryId = 12, Name = "Practice and Routine", Description = "", ParentThemeId = 4, Status = "Inactive" },

            new Category { CategoryId = 13, Name = "Daily Practices", Description = "", ParentThemeId = 5, Status = "Inactive" },
            new Category { CategoryId = 14, Name = "Mindfulness and Relaxation", Description = "", ParentThemeId = 5, Status = "Inactive" },
            new Category { CategoryId = 15, Name = "Gratitude and Positivity", Description = "", ParentThemeId = 5, Status = "Inactive" }

       };

        // Predefined Goals data
        public static List<Goal> Goals => new List<Goal>
        {
            new Goal { GoalId = 1, Description = "Complete a bodyweight squat for 1 minute.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 2, Description = "Perform 10 push-ups in a row.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 3, Description = "Deadlift your body weight.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 4, Description = "Bench press your body weight.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 5, Description = "Complete 3 sets of 10 reps on all major lifts.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 6, Description = "Increase your squat weight by 10% in 4 weeks.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 7, Description = "Hold a plank for 1 minute.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 8, Description = "Complete 5 pull-ups.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 9, Description = "Increase your deadlift by 5% each month.", ParentCatId = 1, Status = "Inactive" },
            new Goal { GoalId = 10, Description = "Achieve a clean and press with 50% of your body weight.", ParentCatId = 1, Status = "Inactive" },


            new Goal { GoalId = 11, Description = "Run a mile in under 8 minutes.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 12, Description = "Cycle for 30 miles in one session.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 13, Description = "Swim 500 meters without stopping.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 14, Description = "Complete a 5K run.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 15, Description = "Increase your jogging distance by 10% each week.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 16, Description = "Attend a spin class 3 times a week for a month.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 17, Description = "Row 2000 meters in under 8 minutes.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 18, Description = "Jump rope for 10 minutes straight.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 19, Description = "Hike a local trail with an elevation gain of 1000 feet.", ParentCatId = 2, Status = "Inactive" },
            new Goal { GoalId = 20, Description = "Participate in a local charity run or walk.", ParentCatId = 2, Status = "Inactive" },


            new Goal { GoalId = 21, Description = "Touch your toes while standing.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 22, Description = "Complete a full split.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 23, Description = "Perform 10 minutes of yoga every day for a month.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 24, Description = "Increase your shoulder flexibility with overhead stretches.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 25, Description = "Hold a downward dog for 1 minute.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 26, Description = "Achieve a full range of motion in hip flexors.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 27, Description = "Master the pigeon pose.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 28, Description = "Work on your thoracic spine mobility.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 29, Description = "Do 5 minutes of dynamic stretching before workouts.", ParentCatId = 3, Status = "Inactive" },
            new Goal { GoalId = 30, Description = "Increase your hamstring flexibility by practicing daily stretches.", ParentCatId = 3, Status = "Inactive" },


            new Goal { GoalId = 31, Description = "Set clear goals for each study session.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 32, Description = "Use a study schedule to manage your time effectively.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 33, Description = "Find a quiet, distraction-free environment to study.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 34, Description = "Break study material into smaller, manageable chunks.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 35, Description = "Use the Pomodoro Technique (25 minutes of study, 5-minute break).", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 36, Description = "Review notes regularly to reinforce memory.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 37, Description = "Practice active recall by testing yourself on the material.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 38, Description = "Teach the material to someone else to solidify your understanding.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 39, Description = "Use flashcards for memorization of key concepts.", ParentCatId = 4, Status = "Inactive" },
            new Goal { GoalId = 40, Description = "Stay organized with a binder or digital notes.", ParentCatId = 4, Status = "Inactive" },


            new Goal { GoalId = 41, Description = "Find your learning style (visual, auditory, kinesthetic) and adapt.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 42, Description = "Set short-term and long-term goals for your studies.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 43, Description = "Use positive affirmations to boost confidence.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 44, Description = "Keep a study journal to reflect on your progress.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 45, Description = "Stay curious and ask questions about the material.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 46, Description = "Reward yourself for reaching study milestones.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 47, Description = "Embrace mistakes as part of the learning process.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 48, Description = "Keep a consistent daily routine for studying.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 49, Description = "Find a study buddy for motivation and accountability.", ParentCatId = 5, Status = "Inactive" },
            new Goal { GoalId = 50, Description = "Adjust your study methods if something isn't working.", ParentCatId = 5, Status = "Inactive" },


            new Goal { GoalId = 51, Description = "Begin studying well in advance of exam dates.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 52, Description = "Create a study guide summarizing key concepts.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 53, Description = "Take practice exams under timed conditions.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 54, Description = "Identify your weak areas and focus on them.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 55, Description = "Form a study group for mutual support and accountability.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 56, Description = "Use mnemonics to remember complex information.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 57, Description = "Stay healthy with adequate sleep, nutrition, and exercise.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 58, Description = "Set aside time for relaxation to reduce stress.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 59, Description = "Familiarize yourself with the exam format and rules.", ParentCatId = 6, Status = "Inactive" },
            new Goal { GoalId = 60, Description = "Review exam feedback to improve future performance.", ParentCatId = 6, Status = "Inactive" },


            new Goal { GoalId = 61, Description = "Set clear goals for your language learning (e.g., conversational fluency).", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 62, Description = "Create a study schedule and stick to it.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 63, Description = "Use language learning apps like Duolingo, Babbel, or Rosetta Stone.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 64, Description = "Start with the most common vocabulary and phrases.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 65, Description = "Learn basic grammar rules to form sentences.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 66, Description = "Use flashcards for memorization of vocabulary.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 67, Description = "Practice with language exchange partners.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 68, Description = "Immerse yourself in the language through music and podcasts.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 69, Description = "Watch movies and TV shows in the target language.", ParentCatId = 7, Status = "Inactive" },
            new Goal { GoalId = 70, Description = "Read children’s books or simple texts to build confidence.", ParentCatId = 7, Status = "Inactive" },


            new Goal { GoalId = 71, Description = "Listen to audiobooks in the target language.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 72, Description = "Repeat phrases out loud to improve pronunciation.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 73, Description = "Use shadowing technique—mimic native speakers.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 74, Description = "Join a conversation club or language meetup.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 75, Description = "Record yourself speaking and listen for improvements.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 76, Description = "Use language-learning YouTube channels.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 77, Description = "Practice speaking with AI language bots.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 78, Description = "Use voice recognition features in apps for pronunciation feedback.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 79, Description = "Engage in role-play scenarios for real-life practice.", ParentCatId = 8, Status = "Inactive" },
            new Goal { GoalId = 80, Description = "Focus on intonation and rhythm of the language.", ParentCatId = 8, Status = "Inactive" },

            new Goal { GoalId = 81, Description = "Read news articles or blogs in the target language.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 82, Description = "Keep a journal in the new language.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 83, Description = "Write short essays or summaries of what you read.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 84, Description = "Use graded readers tailored for language learners.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 85, Description = "Explore online forums in the target language.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 86, Description = "Set up a language blog to share your learning journey.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 87, Description = "Translate favorite songs or poems into the new language.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 88, Description = "Participate in online writing communities for feedback.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 89, Description = "Use language learning websites with reading exercises.", ParentCatId = 9, Status = "Inactive" },
            new Goal { GoalId = 90, Description = "Write down new words and their meanings daily.", ParentCatId = 9, Status = "Inactive" },


            new Goal { GoalId = 91, Description = "Master the major scale in all keys.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 92, Description = "Learn the minor scale in all keys.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 93, Description = "Practice finger exercises for dexterity.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 94, Description = "Work on long tones to improve sound quality.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 95, Description = "Develop a consistent vibrato technique.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 96, Description = "Play chords in different inversions.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 97, Description = "Improve strumming patterns (for guitar).", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 98, Description = "Master legato and staccato playing.", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 99, Description = "Focus on dynamic control (soft and loud playing).", ParentCatId = 10, Status = "Inactive" },
            new Goal { GoalId = 100, Description = "Learn proper breathing techniques (for wind instruments).", ParentCatId = 10, Status = "Inactive" },


            new Goal { GoalId = 101, Description = "Learn and memorize one new piece each month.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 102, Description = "Tackle a challenging piece that’s outside your comfort zone.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 103, Description = "Explore a new genre (e.g., jazz, classical, pop).", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 104, Description = "Learn to play a piece by ear.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 105, Description = "Create a setlist of your favorite songs to perform.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 106, Description = "Perform a piece with accompaniment.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 107, Description = "Learn a piece from a different culture or country.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 108, Description = "Transcribe a song from your favorite artist.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 109, Description = "Play a duet with another musician.", ParentCatId = 11, Status = "Inactive" },
            new Goal { GoalId = 110, Description = "Participate in a recital or performance.", ParentCatId = 11, Status = "Inactive" },


            new Goal { GoalId = 111, Description = "Establish a daily practice routine.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 112, Description = "Set specific practice goals for each session.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 113, Description = "Track your practice time with a journal.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 114, Description = "Use a metronome to develop timing and rhythm.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 115, Description = "Break down difficult passages into smaller sections.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 116, Description = "Incorporate warm-up exercises into your routine.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 117, Description = "Practice slowly before increasing speed.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 118, Description = "Focus on one technique each week.", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 119, Description = "Set a timer for focused practice sessions (e.g., 25 minutes).", ParentCatId = 12, Status = "Inactive" },
            new Goal { GoalId = 120, Description = "Regularly review past pieces to maintain skills.", ParentCatId = 12, Status = "Inactive" },


            new Goal { GoalId = 121, Description = "Keep a gratitude journal to note three things you’re thankful for each day.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 122, Description = "Practice mindfulness meditation for 5-10 minutes.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 123, Description = "Take a nature walk to enjoy fresh air and scenery.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 124, Description = "Establish a daily routine for structure and stability.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 125, Description = "Limit screen time to reduce stress and anxiety.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 126, Description = "Engage in deep breathing exercises to promote relaxation.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 127, Description = "Set daily intentions to focus your mind and energy.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 128, Description = "Drink enough water to stay hydrated.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 129, Description = "Practice positive affirmations to boost self-esteem.", ParentCatId = 13, Status = "Inactive" },
            new Goal { GoalId = 130, Description = "Limit caffeine intake to reduce anxiety.", ParentCatId = 13, Status = "Inactive" },


            new Goal { GoalId = 131, Description = "Practice progressive muscle relaxation to release tension.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 132, Description = "Listen to calming music or nature sounds.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 133, Description = "Try guided imagery for stress relief.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 134, Description = "Create a cozy space for relaxation and reflection.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 135, Description = "Read a book that interests you.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 136, Description = "Engage in aromatherapy with essential oils.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 137, Description = "Create a vision board to visualize goals.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 138, Description = "Spend time with pets for companionship and joy.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 139, Description = "Try tai chi or qigong for mindfulness and movement.", ParentCatId = 14, Status = "Inactive" },
            new Goal { GoalId = 140, Description = "Practice self-compassion and forgive yourself for mistakes.", ParentCatId = 14, Status = "Inactive" },


            new Goal { GoalId = 141, Description = "Keep a daily gratitude list.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 142, Description = "Practice random acts of kindness for others.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 143, Description = "Reflect on positive experiences each week.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 144, Description = "Create a positivity jar with uplifting notes.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 145, Description = "Celebrate small victories in your day-to-day life.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 146, Description = "Focus on solutions rather than problems.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 147, Description = "Surround yourself with positive people.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 148, Description = "Limit exposure to negativity (news, social media).", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 149, Description = "Practice forgiveness for yourself and others.", ParentCatId = 15, Status = "Inactive" },
            new Goal { GoalId = 150, Description = "Engage in positive self-talk to uplift your mood.", ParentCatId = 15, Status = "Inactive" }

        };
    }
}