using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hophacks
{
    public partial class Form2 : Form
    {
        public static string txt = "";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        public string Str()
        {
            return txt;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            txt = "Dear Representative, We need your support in voting down bill HB-2398. Currently 57 of 120 representatives are currently voting no on this bill. We need your assistance if public education in Baltimore is to maintain its prestige. The senate has currently passed the bill, and you are our last hope. Over $11 million will be redirected to other funds such as subsidizing steel monopolies and unnecessary military measures.Without this funding, public schools and our children will begin lagging behind other ciites. It is your duty to protect our children.";
            f3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            txt = "A 190 mile fracked gas pipeline is proposed for Maryland's Eastern Shore, starting in Rising Sun (Cecil County), passing through all Eastern Shore counties (except for Worcester), before crossing into Virginia to end at a proposed power station in Accomack County (not built yet; we'll post more about that project as we can.) There are also rumors that this will serve a proposed power station in Denton MD.This pipeline, like all pipelines, will cross rivers, farms, and forests, irreparably damaging the earth along the way.The areas it will \"service\" are not residential; in other words the pipeline is a conduit for profit for the energy companies behind it.As organizations, activists and residents in Maryland are pushing for the state to adopt clean energy sources, the powers that be are determined to squeeze every last penny of profit they can from dirty fossil fuels first.Maryland has already banned the destructive practice of hydraulic fracturing(fracking) and yet our governor continues to not only allow, but encourages fracked gas pipelines to be build, which destroy our environment. This happens under the auspice of \"job creation\" which has been proven false.The reason for these pipelines is profit, plain and simple. We must stand together to stop this pipeline before it starts AND to push our lagging government to make the transition to support clean, renewable energy sources in Maryland.";
            f3.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            Form3 f3 = new Form3();
            txt = "Subway has already taken steps to reduce their waste: their napkins are made with 100% recycled fiber, their salad bowls were redesigned to remove 2.62 million pounds of plastic from their waste stream, and they have changed the design of their cup carriers to save thousands of trees per year. It's clear the restaurant chain wants to be known for its environmental sustainability ― but their use of plastic straws is still an issue. As one of the most influential restaurant chains in America, the number of plastic straws they use ― and the number that end up in our oceans, swallowed by sea turtles ― is concerning.Why not take a bold step and implement a \"straw upon request\" policy in their stores? With this policy, the use of straws are still available to those who require it to drink, such as children or those with physical disabilities.This subtle change would not greatly reduce the unnecessary use of straws, but also bring attention to the urgency of the battle against plastic pollution. Please urge Subway to help end plastic straw waste by implementing a plastic \"straw upon request\" policy.";
            f3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            txt = "We’ve been eating meat since we lived in caves. And today, some of our most magical moments together happen around meat: Weekend barbecues. Midnight fast-food runs. Taco Tuesdays. Hot dogs at the ballpark. Those moments are special, and we never want them to end. But using animals to make meat is a prehistoric and destructive technology. Animal agriculture occupies almost half the land on earth, consumes a quarter of our freshwater and destroys our ecosystems. So we’re doing something about it: We found a way to make meat using plants, so that we never have to use animals again. That way, we can eat all the meat we want, for as long as we want. And save the best planet in the known universe. Mission Impossible: We make delicious meat from plants.All the mouthwatering flavor – with a tiny fraction of the environmental impact of meat from cows.We hope you’re hungry.";
            f3.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            txt = "Now is not the time for silence. It's time for outrage. Our hearts go out to the families and friends of the hundreds of people that were killed or injured at the Mandalay Bay Casino mass shooting in Las Vegas, the worst in the nation's history. But sympathy will not save the 33,000 Americans who will be killed this year by gun violence. Legislators beholden to the gun lobby will no doubt say now is not the time to talk about gun laws. There is no other kind of attack on Americans that is met with this level of indifference.It needs to stop. Right now Congress is considering deregulating silencers which would make it harder to identify from where gunshots are coming in active shooter situations.The House is close to passing a bill making it easier for people to carry concealed weapons to any state in the nation with not so much as a background check.";
            f3.ShowDialog();
        }
    }
}
