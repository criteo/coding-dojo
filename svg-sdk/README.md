Overview of the dojo
====================

The goal is to implement a small sdk that can be used to generate simple [SVG](https://en.wikipedia.org/wiki/SVG) images.

So the idea is to end up with a code that would look like something like this pseudo-code:

```
Create svg with dimensions w,h
Add a rectangle with those properties
Add an ellipse like this
Write it to myImage.svg
```

Note that this topic is a bit particular, in the sense that it is not TDD based. You can write tests if you want to but it will be more convenient to test what you did by just opening the generated svg and checking it represents what you expect.

The goals are more:

- discovering the SVG format
- designing a small sdk (and finding a correct balance between coming up with an advanced design and [YAGNI](https://en.wikipedia.org/wiki/You_aren%27t_gonna_need_it))

How does SVG work
=================

Quoting wikipedia: SVG is a

> vector graphics format for defining two-dimensional graphics

Under the hood SVG is XML-based, which means we can create create an SVG file with just a text editor.

Though it's not needed for this dojo, you may want to refer to the [SVG tutorial on MDN](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorials/SVG_from_scratch) to learn more about this format.

How is this dojo intended to be performed
=========================================

The goal is to develop an sdk that is manipulated by code in the "main" in order to generate an SVG (we provide a scaffolding for that but feel free to change it) implementing successively those features

- step 1: Generate an empty svg with the given dimensions
- step 2: Make it possible to draw a [rectangle](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Element/rect) (at any position, with any size, any given background color, and any stroke color and width)
- step 3: Also make it possible draw [ellipses](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Element/ellipse). Use this to draw a simple sheep (1 ellipse for the body, 1 for the head, 1 circle with another color for an eye, and 2 rectangles for the legs)
- step 4: Make is possible to draw [paths](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Element/path). Use this add a kind of moutain behind the sheep.
- step 5: Add support for [mask](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Element/mask) and [gradient](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Element/radialGradient). Use it to add a rainbow in the background (draw a circle with a rainbow-ish radial gradient, and cut off its lower half and inner part with a mask).

Note that this directory contains an example svg for each step, so you can look at what they look like and at their source.

The first 4 steps should be doable in ~1h30. The 5th step is a bit more involving.

If you want to go farther here are a couple of other ideas:
- support [<use>](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Element/use) and transformations (scaling, transformations)
- support [viewBox](https://developer.mozilla.org/en-US/docs/Web/SVG/Reference/Attribute/viewBox)
- extend the sdk to support transformation of an existing svg (eg: make it possible to read an existing svg file, to change the color of a given shape, and to save it back afterwards)

Tips & tricks
=============

- To render an SVG file (ie: to see the image) you can open it in any SVG viewer. For instance Firefox.
- To see the code of an SVG file, just open it in any text editor. For instance ViM.
- To easily see the impact of a small change in an SVG file you can open it in Firefox, open Firefox developer tools, and edit the SVG from here: its representation will directly be updated.
