﻿using System;
using Math.Nodes.Functions.Binary;
using Math.Nodes.Values;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class PowNodeTests
    {
        [TestMethod]
        public void PositiveNumbersPowTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(2);
            power.RightNode = new NumberNode(3);

            Assert.AreEqual(8, power.Evaluate());
        }
        
        [TestMethod]
        public void NegativeNumbersPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(-3);
            power.RightNode = new NumberNode(-5);

            Assert.AreEqual(-0.00411522633744856m, power.Evaluate());
        }

        [TestMethod]
        public void PositiveDecimalNumbersPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(32.23m);
            power.RightNode = new NumberNode(0.9m);

            Assert.AreEqual(22.7737356376674m, power.Evaluate());
        }

        [TestMethod]
        public void NegativeDecimalNumbersPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(3.2m);
            power.RightNode = new NumberNode(-1.9m);

            Assert.AreEqual(0.109702125246383m, power.Evaluate());
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void NegativeDecimaleOverflowNumbersPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(-64.32m);
            power.RightNode = new NumberNode(-0.8m);

            power.Evaluate();
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void OverflowPositiveNumbersPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(9999999999999999999);
            power.RightNode = new NumberNode(9999999999999999999);
            power.Evaluate();
        }

        [TestMethod]
        public void FirstZeroNumberPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(0);
            power.RightNode = new NumberNode(2);

            Assert.AreEqual(0, power.Evaluate());
        }

        [TestMethod]
        public void SecondZeroNumberPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(2);
            power.RightNode = new NumberNode(0);

            Assert.AreEqual(1, power.Evaluate());
        }

        [TestMethod]
        public void BothZeroNumberPowerTest()
        {
            PowNode power = new PowNode();
            power.LeftNode = new NumberNode(0);
            power.RightNode = new NumberNode(0);

            Assert.AreEqual(1, power.Evaluate());
        }


    }

}