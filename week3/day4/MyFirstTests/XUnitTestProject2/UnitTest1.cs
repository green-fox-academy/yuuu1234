using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;
using MyFirstTests;
namespace XUnitTestProject2
{
    public class UnitTest1
    {
        //Apple
        Apple apple=new Apple();
        [Fact]
        public void TestGetApple()
        {
            string result = apple.GetApple();
            Assert.Equal("Apple",result);
        }

        //Sum
        MethodCollection method=new MethodCollection();


        [Fact]
        public void TestSum()
        {
            int result1 = method.Sum(new List<int>() {1, 2, 3, 4, 5});
            int result2 = method.Sum(new List<int>() {1});
            int result3 = method.Sum(new List<int>() { });
            int result4 = method.Sum(null);
            Assert.Equal(15,result1);
            Assert.Equal(1, result2);
            Assert.Equal(0, result3);
            Assert.Equal(0, result4);
        }
       
        //Anagram
        [Fact]

        public void TestAnagram()
        {
            bool result=method.Anagram("abc", "cba");
            Assert.Equal(true,result);
        }
        
        //Count letters
        [Fact]
        public void TestCountLetters()
        {
            Dictionary<char,int> correct=new Dictionary<char, int>(){{'h',1},{'e',1},{'l',2},{'o',1}};
            Dictionary<char, int> result = method.CountChars("hello");
            Assert.Equal(correct,result);
        }

        //Fibonacci

        [Fact]

        public void TestFibonacci()
        {
            int result = method.Fibonacci(3);
            Assert.Equal(3, result);
        }

        //
        
        //Extention
        Extension extension = new Extension();

        [Fact]
        public void TestAdd_2and3is5()
        {
            Assert.Equal(11, extension.Add(8, 3));
        }

        [Fact]
        public void TestAdd_1and4is5()
        {
            Assert.Equal(5, extension.Add(1, 4));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(12, extension.MaxOfThree(12, 8, 9));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(3, 4, 5));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 7, 4, 3, 5 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 2, 3, 4, 5, 6}));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.Equal(true,extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.Equal(true,extension.IsVowel('u'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }

        //CAB
        CABGame cab=new CABGame();

        [Fact]
        public void CABGameTest()
        {
            cab.StartPlay();
        }
    }
}
