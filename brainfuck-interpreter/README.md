Overview of the dojo
====================

The goal of this dojo is to implement a [brainfuck](https://en.wikipedia.org/wiki/Brainfuck) interpreter (nb: no prior knowled of brainfuck is expected.).

This repo contains tests for all the operator we want to implement, but if you want to dig deeper you may want to write more advanced tests towards the end of the dojo.

What is brainfuck
=================

Brainfuck is a minimilistic programming lanuage: it has only eight commands. It is subsequently not so hard to write an interpreter. (But it is pretty complex to write (and even more to read) brainfuck code).
In this dojo we will implement an interpreter for a slightly simplified version of brainfuck, with only seven operators.

Here is what we want to implement (taken from [the wikipedia page of brainfuck](https://en.wikipedia.org/wiki/Brainfuck) and slightly adapted):

The brainfuck language uses a simple machine model consisting of the program and instruction pointer, as well as a one-dimensional array of at least 30,000 byte cells initialized to zero; a movable data pointer (initialized to point to the byte at the middle of the array). 
 
This language has eight instructions, each consisting of a single character. However, in this dojo we will only implement those seven instructions:

| Character | Instruction performed |
| ----------|---------------------- |
| >         | Increment the data pointer by one (to point to the next cell to the right). |
| <         | Decrement the data pointer by one (to point to the next cell to the left). |
| +         | Increment the byte at the data pointer by one. |
| -         | Decrement the byte at the data pointer by one. |
| .         | Output the byte at the data pointer |
| [         | If the byte at the data pointer is zero, then instead of moving the instruction pointer forward to the next command, jump it forward to the command after the matching ] command. |
| ]         | If the byte at the data pointer is nonzero, then instead of moving the instruction pointer forward to the next command, jump it back to the command after the matching [ command  |


How is this dojo intended to be performed
=========================================

Just open the test suite and run it. It should be green because at first we only test that no instructions yield no output.

The goal now is to uncomment the tests one by one and turn them green one after the other. Ultimately you should be able to run a program that output an "Hello World".

It should be doable in less than 1h30 ~ 2h.

Possible extension if you want to go farther: instead of writing an brainfuck interpreter, try writing a brainfuck compiler
