#Stage 1 -----------------------------------------------------------
# Use an official Node runtime as a base image
FROM node:latest as build

# Set the working directory inside the container
WORKDIR /app

# Copy package.json and package-lock.json to the working directory
COPY package*.json ./

# Install dependencies
RUN npm install

# Copy the application code to the working directory
COPY . .

# Build the Angular app
RUN npm run build --prod

# Stage 2 -----------------------------------------------------------
FROM nginx:alpine

# Copy builded project into Nginx
COPY --from=build /app/dist/shipping-service /usr/share/nginx/html

# Expose the port the app runs on
EXPOSE 80