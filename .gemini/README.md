# Gemini Code Assist Instructions

This directory contains instructions and prompts for Google Gemini Code Assist CLI.

## Structure

- `code_assist_instructions.md` - Main instructions for Gemini Code Assist, containing coding patterns and guidelines for this project
- `Quality/` - Additional quality assurance prompts referenced by the main instructions
  - `qacontext.prompt.md` - QA context definitions
  - `namingconsistency.prompt.md` - Naming pattern consistency rules
  - `decouplingcheck.prompt.md` - Decoupling requirements
  - `codeguidelines.prompt.md` - Code review guidelines

## Usage

Gemini Code Assist will automatically read the `code_assist_instructions.md` file when working with this repository to ensure code changes follow the project's patterns and conventions.

## Relationship to Copilot Instructions

These instructions mirror the GitHub Copilot instructions found in `.github/prompts/copilot-instructions.md` to ensure consistent behavior across different AI code assistants.
