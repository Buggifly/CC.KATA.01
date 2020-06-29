# Clean Code KATA #01

## Description

The KATA is based on an application that's designed for laying out text on a page.  
Every piece of text is placed inside a **Frame** that has specific dimensions.  
If the frame is too small for the content to fit, then a *warning* icon is displayed in either the bottom left or the
bottom right corner, according to the configuration.

## Information

- The size of the overflow icon is fixed at 32 x 32 pixels.
- The minimum size of a frame is always 50 x 50 pixels
- The overflow icon needs to be placed 5 pixels from the frame's boundaries.

## Assignment

Right now, the icon that's displayed to indicate that the frame is too small for the content to FIT can be placed either
on the bottom left, or on the bottom right.  
Your task is to add *Top Left* and *Top Right* to the possible locations where the icon can be placed.

Implementing this behaviour can be done by adding a simple 'CASE' to the 'SWITCH' statement.  
However, the code is already is a BAD state and we don't want it to get any worse, therefore, the code should be
refactored to *Clean Code* standard while implementing this behaviour.

## Requirements

- Write *'Unit Tests'* for the method `TextFrameController.CheckIfOverflow`.  
  **NOTE:** We do NOT want to tests collaborators, only the logic of the given method.  

- Changing the code is NOT allowed when it's not covered by *'Unit Tests'*.  
  The only possible changes to the existing code are *'Automatic Refactorings'*, supported by the IDE.

- The refactored code should be covered by Unit Tests, so that any changes in the future can be done in a safe way.
