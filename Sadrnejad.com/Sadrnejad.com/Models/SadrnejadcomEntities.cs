using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace Sadrnejad.com.Models
{
    public class SadrnejadcomEntities : DbContext
    {
        public SadrnejadcomEntities() 
        : base("SadrnejadcomEntities")
        {
            //Database.SetInitializer<SadrnejadcomEntities>(new SadrnejadcomDBInitializer());

            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }

    public class SadrnejadcomDBInitializer : DropCreateDatabaseAlways<SadrnejadcomEntities>
    {
        protected override void Seed(SadrnejadcomEntities context)
        {
            IList<Category> defaultCategories = new List<Category>();

           defaultCategories.Add(new Category() { Title = "Category 1", Description = "First Category" });
           defaultCategories.Add(new Category() { Title = "Category 2", Description = "Second Category" });
           defaultCategories.Add(new Category() { Title = "Category 3", Description = "Third Category" });

            foreach (Category category in defaultCategories)
                context.Categories.Add(category);

            context.SaveChanges();

            IList<Post> defaultPosts = new List<Post>();

            defaultPosts.Add(new Post() {
                Category_ID = defaultCategories[1].ID,
                Title = "Social Network effects on our life",
                ShortDescription = " First of all we when we get on we waste our time god has given us and other reason is that we are wasting time of the real word and when we go to face to face ever one is so scared about it and on social media no one cares what they say",
                Article = @"In the last ten years the use of electronic communication devices has boomed. Most of us have mobile phones and the majority of under 30 year olds have smart phones. The use of computers has become an integral part of our lives. Instant messaging and emails have overtaken letters as the most popular way to keep in touch.

These new forms of communication have benefits but can also cause anxiety,
                poor self esteem and can be all - consuming to the detriment of work and friendships.Are you more stressed since you joined a social media site ? Everyone is always on the end of a line but this instant availability can also be intrusive.The jury is out on whether texting and emailing is addictive,
                but for some their lives do seem to be controlled by social media.

When was the last time you were out for a meal and either you or someone at the table had their phone on and responded to a text ? Have you ever gone out to lunch and discovered that you had left your mobile on your desk ? How did you react - panic or acceptance ? Do you scroll and stroll and ignore others on the street ?

For some social media affects their self esteem.Knowing what friends are doing, where they are going, what they are seeing is a bit voyeuristic(but with their permission).You may end up comparing yourself to them and feeling inadequate.If you are not doing something as great or exciting you may feel worthless.Your self esteem becomes dented.In some cases, to counteract this, you may then make stories up and, if not careful, get trapped in a web of lies.

We all need time out. We need to be able to recharge our mental batteries. This hyper-state of involvement in others' lives that technology brings can train us to be constantly online so that we don’t miss out. Even at work there is an expectation that we ‘are on-call’. Some employees feel that they have to check work phones and emails during their holidays so that the boss knows they are dedicated. Not much of a break.

Holidays are useful ways to rest the brain. To give it time to recharge. These time-outs are very beneficial and help to prevent stress and breakdowns. So if you can’t turn off your phone, do you think you may have become dependent on knowing what others are doing? And if so, why?

Some have difficulties putting technology into place and not let it take over their lives. More and more clients are coming in because they feel inadequate. They compare and contrast their lives with the ‘electronic friends’ and don’t feel as exciting, as perfect, as fulfilled.Their lives are becoming stressful because of technology not better.",
                PostedOn = DateTime.ParseExact("07/01/2016", "dd/MM/yyyy", null),
                Modified = DateTime.ParseExact("07/01/2016", "dd/MM/yyyy", null),
                Published = true,
            });
            defaultPosts.Add(new Post()
            {
                Category_ID = defaultCategories[2].ID,
                Title = "Tips for buying second-hand",
                ShortDescription = @"Usually the problem is a fault which needs essential repair. About 7% of the time the car needs to be scrapped.

Here are some steps you can take to minimise the chances of nasty surprises down the line.",
                Article = @"1.	What to buy

Review your budget and work out what you can afford and what you can get for that price.

Do your research by checking adverts on websites and magazines to get an idea of the market.

If you have a specific model in mind, you can estimate prices on websites like What Car? or Parkers.

Cars with bigger engines may seem relatively cheap, but bear in mind the running costs (especially fuel, tax and insurance) may be higher.

2.	Buying from a dealer

Continue reading the main story
Trade associations

Manager's special
Check the dealer for a trade association sign.

If the business is a member, they have to follow a code of practice.

If you're not sure if the sign is genuine, you can check their membership with the trade association

Buying a car from a dealer may cost more but gives legal protection under the Sale of Goods Act.

This means the car must match the description given by the seller.

It should also be of satisfactory quality, fit for purpose and roadworthy.

Selling a car that's not fit for the road is a criminal offence.

If you find there was a problem with the car when you bought it, you can ask the dealer for your money back or a repair.

Choose your dealer carefully - ask people you know for recommendations.

3. Buying privately

There are various ways you can buy a car privately - online, at an auction or through an advert in a newspaper.

You'll probably be able to get a cheaper price but you won't be protected by the Sale of Goods Act.

However, the car still has to be "" as described"" so ask plenty of questions about its condition and get the answers in writing.

If the car turns out to have a fault,
                you'll need to be able to challenge the seller's description to get your money back.

4.When you see the car

Jump media playerMedia player helpOut of media player.Press enter to return or tab to continue.
Independent vehicle examiner Gareth Rees tells BBC Wales's X-Ray what you need to check on a used car
If the seller offers a viewing anywhere other than their home, think twice. It means you might not be sure of where he or she lives if there's a problem.

Don't feel under pressure to make a quick decision. It's important to check the car thoroughly.

Take a look through the 10 top tips for checking a used car from consumer group Which ? or use the checklist provided by the AA.

If you don't know much about cars, take someone who does.

If you're still not sure, consider getting an independent report - though it may be expensive.

5.Online checks

Before you strike up a deal you should:

Check the car's identity

Continue reading the main story
Is it stolen ? The warning signs

There's no vehicle registration document (V5C)
The V5C has spelling mistakes, alterations or no watermark
The name and address on the V5C don't match the seller's. (Ask to see their driving licence, passport, or recent utility bill)
The identifying numbers on the car don't match the numbers on the V5C or look like they've been altered
The seller has no insurance policy for the car
Go to the DVLA website to check the following details match the ones given by the seller.

Year of manufacture
Date the car was first registered
Engine capacity
Colour
Expiry date of the current tax disk
Tax rate(known as vehicle excise duty rate).
The MOT history

Check the car's MOT history online using its registration (number plate) and either the MOT test number or the reference number from the V5C registration certificate.

This will tell you the date of previous tests, the mileage readings at those tests and any reasons for failure.

Consider a private history check

You will have to pay to get this done but a history, or data check will tell you if the car has

Outstanding finance owing on it
Been reported stolen
Been in a serious accident
The correct mileage
There are various companies that offer this service online - including the AA and RAC.Make sure that whatever company you chose they take responsibility for the accuracy of information they supply.

6.	Paying for the car

Buying a used car wouldn't be the same without haggling over the price.

Doing some research on being a good haggler could definitely save you hundreds.

Continue reading the main story
Cutting fuel costs

Refuelling
Remove unnecessary weight from your car
Drive for consumption, not for speed.Avoid sudden braking or acceleration
Maintain your car well
Plan your journeys
Save more fuel
Once you agree a price the safest way to pay is with a credit card so that you have added protection under the Consumer Credit Act.However, if you're buying privately you probably won't be able to do this.

If you pay by cheque or through online banking, the seller will probably wait for the payment to clear before parting with the car.

You can also pay using a banker's draft. You won't have to wait for it to clear but you will have to pay a fee to your bank.

Either way, always remember to get a signed and dated receipt.It should include the buyer and seller names and addresses along with the vehicle details and price.

If your car comes from an internet business, under the Distance Selling Regulations you have a 7-day cooling off period to change your mind about the deal.

7.	After you've paid

Continue reading the main story
Extra tips

Keep copies of any advertisement or description of the car in case it's needed at a later date
Do not agree or sign anything unless you are absolutely sure you want to go ahead with it
If the deal is subject to finance, neither party is legally bound until the finance agreement has been signed by both
Beware of signing any document that states you have examined the car and found it satisfactory in all respects
If the car was sold with a guarantee or an extended warranty, you may have additional rights
Citizens Advice
When the deal is complete, both parties will need to fill in the V5C registration document, which the seller needs to send to the DVLA.

You should be given the ""new keeper"" section of the document.

Make sure you have all the other documents including the MOT certificate - if the car is more than three years old - and any receipts for repairs.

Make sure you get the manuals as well as a code for the radio.

If the car is supposed to have a spare wheel, check it's there, along with any tools you need to change it.

Finally, make sure you've been given a spare key - it can be very expensive to get replacements cut.

8.	If things go wrong

If the car has a fault which you were told about before you bought it you might not be able to claim, unless the problem is far worse than described.

It's also difficult to make a case against the seller for problems that would have been obvious before buying - like a large dent or rust on the bodywork.

However, if you notice the fault soon after buying the car and you haven't been told about it, you could claim a full or partial refund from the seller.",
                PostedOn = DateTime.ParseExact("11/12/2015", "dd/MM/yyyy", null),
                Modified = DateTime.ParseExact("17/12/2015", "dd/MM/yyyy", null),
                Published = true,
            });

            foreach (Post post in defaultPosts)
                context.Posts.Add(post);

            base.Seed(context);
        }
    }
}